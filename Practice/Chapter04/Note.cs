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

namespace Chapter04
{
	public partial class Note : Form
	{
		private Boolean bNoteChange;
		private string findWord;
		private Finder finder;


		public Note()
		{
			InitializeComponent();
		}

		private void Init()
		{
			tbNote.ResetText();
			Text = "제목 없음";
			bNoteChange = false;
		}

		private DialogResult ShowChangeMessageBox()
		{
			var msg = Text + " 파일의 내용이 변경되었습니다.\r\n" + "변경된 내용을 저장하시겠습니까?";
			return MessageBox.Show( msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning );
		}

		private void 새로만들기NToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( bNoteChange )
			{
				// FileName 파일의 내용이 변경되었습니다.
				// 변경된 내용을 저장하시겠습니까?
				var dr = ShowChangeMessageBox();

				if( DialogResult.Cancel == dr )
					return;

				if( DialogResult.Yes == dr )
					TextSave();

				Init();
			}
			else
			{
				Init();
			}
		}

		private void WriteText( string str )
		{
			var sw = new StreamWriter( str, false, System.Text.Encoding.Default );
			sw.Write( tbNote.Text );
			sw.Flush();
			sw.Close();

			Text = str;
			bNoteChange = false;
		}

		private void TextSave()
		{
			if( "제목 없음" == Text )
			{
				var dr = sfDialog.ShowDialog();

				if( DialogResult.Cancel != dr )
				{
					var str = sfDialog.FileName;
					WriteText( str );
				}
			}
			else
			{
				var str = Text;
				WriteText( str );
			}
		}   // end TextSave

		private void ReadText( string str )
		{

		}

		private void TextOpen()
		{
			var dr = ofDialog.ShowDialog();

			if( DialogResult.Cancel != dr )
			{
				var str = ofDialog.FileName;
				var sr = new StreamReader( str, System.Text.Encoding.Default );
				tbNote.Text = sr.ReadToEnd();
				sr.Close();

				Text = str;
				bNoteChange = false;
			}
		}

		private void 열기OToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( bNoteChange )
			{
				var dr = ShowChangeMessageBox();

				if( DialogResult.Cancel == dr )
					return;

				if( DialogResult.Yes == dr )
					TextSave();

				TextOpen();
			}
			else
			{

			}
		}

		private void tbNote_TextChanged( object sender, EventArgs e )
		{
			bNoteChange = true;
		}

		private void 다른이름으로저장AToolStripMenuItem_Click( object sender, EventArgs e )
		{
			var dr = sfDialog.ShowDialog();
			if( DialogResult.Cancel == dr )
				return;

			var str = sfDialog.FileName;
			WriteText( str );
		}

		private void btnOk_Click( object sender, EventArgs e )
		{
			var updown = -1;
			var str = tbNote.Text;
			var findWord = finder.tbWord.Text;

			if( !finder.chb.Checked )
			{
				str = str.ToUpper();
				findWord = findWord.ToUpper();
			}

			if( finder.rdb01.Checked )
			{
				if( 0 != tbNote.SelectionStart )
					updown = str.LastIndexOf( findWord, tbNote.SelectionStart - 1 );
			}
			else
			{
				updown = str.IndexOf( findWord, tbNote.SelectionStart + tbNote.SelectionLength );
			}

			// 마지막 도달
			if( -1 == updown )
			{
				MessageBox.Show( "더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			tbNote.Select( updown, findWord.Length );
			findWord = finder.tbWord.Text;
			tbNote.Focus();
			tbNote.ScrollToCaret();
		}

		private void 찾기FToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( !( null == finder || !finder.Visible ) )
			{
				finder.Focus();
				return;
			}

			finder = new Chapter04.Finder();

			if( tbNote.SelectionLength <= 0 )
				finder.tbWord.Text = findWord;
			else
				finder.tbWord.Text = tbNote.SelectedText;

			finder.btnOk.Click += new System.EventHandler( btnOk_Click );
			finder.Show();
		}

		private void 다음찾기NToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( !( null == finder || !finder.Visible ) )
			{
				finder.tbWord.Text = findWord;
				btnOk_Click( this, null );
			}
		}

		private void 저장SToolStripMenuItem_Click( object sender, EventArgs e )
		{
			TextSave();
		}

		private void 끝내기XToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void 실행취소UToolStripMenuItem_Click( object sender, EventArgs e )
		{
			tbNote.Undo();
		}

		private void 잘라내기TToolStripMenuItem_Click( object sender, EventArgs e )
		{
			tbNote.Cut();
		}

		private void 복사CToolStripMenuItem_Click( object sender, EventArgs e )
		{
			tbNote.Copy();
		}

		private void 붙여넣기PToolStripMenuItem_Click( object sender, EventArgs e )
		{
			tbNote.Paste();
		}

		private void 삭제LToolStripMenuItem_Click( object sender, EventArgs e )
		{
			tbNote.SelectedText = "";
		}

		private void 모두선택AToolStripMenuItem_Click( object sender, EventArgs e )
		{
			tbNote.SelectAll();
		}

		private void 시간날짜DToolStripMenuItem_Click( object sender, EventArgs e )
		{
			var time = DateTime.Now.ToShortTimeString();
			var date = DateTime.Today.ToShortDateString();

			tbNote.AppendText( time + "/" + date );
			자동줄바꿈WToolStripMenuItem.Checked = !자동줄바꿈WToolStripMenuItem.Checked;
		}

		private void 글꼴FToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if( DialogResult.Cancel == fontDialog.ShowDialog() )
				return;

			tbNote.Font = fontDialog.Font;
		}

		private void Note_FormClosing( object sender, FormClosingEventArgs e )
		{
			e.Cancel = true;

			if( bNoteChange )
			{
				var dr = ShowChangeMessageBox();
				// 취소면 종료 안함
				if( DialogResult.Cancel == dr )
					return;

				// 저장하기인 경우
				if( DialogResult.OK == dr )
				{
					if( "제목 없음" == Text )
					{
						var sdr = sfDialog.ShowDialog();
						if( DialogResult.Cancel != sdr )
						{
							var str = sfDialog.FileName;
							WriteText( str );
						}
					}
					else
					{
						var str = Text;
						WriteText( str );
					}
				}

				Dispose();
			}
			else
			{
				Dispose();
			}
		}
	}
}
