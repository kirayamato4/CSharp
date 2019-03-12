using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Chapter04
{
	public partial class Form5 : Form
	{
		private FileSystemWatcher watcher;
		private string m_folderPath = String.Empty;
		private bool let = false;

		private delegate void DelegateCreateListBoxItem( string eventName, string dateTime, string filePath );

		public Form5()
		{
			InitializeComponent();
		}

		private void Form5_Load( object sender, EventArgs e )
		{
			cbMonitor.Text = "ON";
		}

		private void btnPath_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != fbDialog.ShowDialog() )
				return;

			tbPath.Text = fbDialog.SelectedPath;
			m_folderPath = fbDialog.SelectedPath;
		}

		private void btnMonitor_Click( object sender, EventArgs e )
		{
			if( "" == tbPath.Text )
				return;

			if( "모니터 ON" == btnMonitor.Text )
			{
				btnMonitor.Text = "모니터 OFF";
				btnSave.Enabled = false;

				watcher = new FileSystemWatcher();
				watcher.Filter = "*." + tbExtension.Text.ToLower();
				watcher.Path = Environment.ExpandEnvironmentVariables( m_folderPath );

				if( "ON" == cbMonitor.Text )
					watcher.IncludeSubdirectories = true;
				else
					watcher.IncludeSubdirectories = false;

				watcher.NotifyFilter =
					NotifyFilters.LastAccess |
					NotifyFilters.LastWrite |
					NotifyFilters.FileName |
					NotifyFilters.DirectoryName;

				watcher.Changed += new FileSystemEventHandler( OnChanged );
				watcher.Created += new FileSystemEventHandler( OnCreated );
				watcher.Deleted += new FileSystemEventHandler( OnDeleted );
				watcher.Renamed += new RenamedEventHandler( OnRenamed );

				watcher.EnableRaisingEvents = true;
			}
			else
			{
				if( null != watcher )
				{
					watcher.Changed -= new FileSystemEventHandler( OnChanged );
					watcher.Created -= new FileSystemEventHandler( OnCreated );
					watcher.Deleted -= new FileSystemEventHandler( OnDeleted );
					watcher.Renamed -= new RenamedEventHandler( OnRenamed );

					watcher.EnableRaisingEvents = false;
				}

				btnMonitor.Text = "모니터 ON";
				btnSave.Enabled = true;
			}
		}

		private void InvokedCreateListViewItme( string eventName, string dateTime, string filePath )
		{
			lvLog.Items.Add( eventName + " : (" + dateTime + ") : " + filePath );
		}

		private void CreateListBoxItem( string eventName, string dateTime, string filePath )
		{
			if( lvLog.InvokeRequired )
			{
				DelegateCreateListBoxItem clbi = new DelegateCreateListBoxItem( InvokedCreateListViewItme );
				Invoke( clbi, new object[ 3 ] { eventName, dateTime, filePath } );
			}
			else
			{
				InvokedCreateListViewItme( eventName, dateTime, filePath );
			}
		}

		private void OnChanged( object sender, FileSystemEventArgs e )
		{
			if( false == let )
			{
				let = true;
				CreateListBoxItem( "Changed", DateTime.Now.ToString(), e.FullPath );
			}
			else
			{
				let = false;
			}
		}

		private void OnCreated( object sender, FileSystemEventArgs e )
		{
			CreateListBoxItem( "Created", DateTime.Now.ToString(), e.FullPath );
		}

		private void OnDeleted( object sender, FileSystemEventArgs e )
		{
			CreateListBoxItem( "Deleted", DateTime.Now.ToString(), e.FullPath );
		}

		private void OnRenamed( object sender, FileSystemEventArgs e )
		{
			CreateListBoxItem( "Renamed", DateTime.Now.ToString(), e.FullPath );
		}

		private void btnSave_Click( object sender, EventArgs e )
		{
			if( DialogResult.OK != sfDialog.ShowDialog() )
				return;

			string savePath = sfDialog.FileName;
			StreamWriter sw = new StreamWriter( savePath );

			foreach( var str in lvLog.Items )
			{
				sw.WriteLine( str );
			}

			sw.Close();
		}
	}
}
