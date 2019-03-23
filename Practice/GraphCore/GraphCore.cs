using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCore
{
	public enum ChartControlOpenType
	{
		Bar,
		Graph,
	};


	public partial class GraphCore : UserControl
	{
		public int _pixelPer;
		public int _lineDifference;
		public float _valueMultiplier;

		public Color _aboveColor;
		public Color _underColor;
		public Color _gridColor;
		public Color _chartBackColor;
		public Color _axisColor;

		public ChartControlOpenType _openType;

		private Graphics _g;
		private float[] _values;
		private float _maximum;
		private float _minimum;

		private int _currentYGridStart;
		private int _currentNumberOfValues;
		private Size _currentSize = new Size( 0, 0 );

		public float Maximum
		{
			get { return _minimum; }
		}

		public float Minimum
		{
			get { return _minimum; }
		}

		public GraphCore()
		{
			InitializeComponent();

			_openType = ChartControlOpenType.Bar;
			LoadDefaultValues();
			InitChart();
		}

		private void LoadDefaultValues()
		{
			_g = panalChart.CreateGraphics();
			_pixelPer = 10;
			_chartBackColor = Color.Black;
			_gridColor = Color.Green;
			_aboveColor = Color.Chartreuse;
			_underColor = Color.Red;
			_axisColor = Color.White;

			_currentYGridStart = 0;
			_valueMultiplier = 1;

			_maximum = panalChart.Size.Height / 2;
			_minimum = -panalChart.Size.Height / 2;

			_lineDifference = 1;

			if( ChartControlOpenType.Bar == _openType )
				_values = new float[ panalChart.Size.Width ];
			else
				_values = new float[ panalChart.Size.Width / 2 ];

			for( int i = 0; i < _values.Length; ++i )
				_values[ i ] = 0;

			_currentNumberOfValues = 0;
		}

		public void InitChart()
		{
			_currentYGridStart = 0;
			PostInitChart();
		}

		public void PostInitChart()
		{
			if( panalChart.Height != 0 && panalChart.Width != 0 )
			{
				_g.Clear( _chartBackColor );
				DrawGrid();
			}
		}

		private void DrawGrid()
		{
			Pen gridPen = new Pen( _gridColor );

			for( int i = ( panalChart.Size.Height / 2 ) + _pixelPer * _lineDifference; i < panalChart.Size.Height; i += _pixelPer * _lineDifference )
				_g.DrawLine( gridPen, 0, i, panalChart.Size.Width, i );

			for( int i = ( panalChart.Size.Height / 2 ) - _pixelPer * _lineDifference; i > 0; i -= _pixelPer * _lineDifference )
				_g.DrawLine( gridPen, 0, i, panalChart.Size.Width, i );

			for( int i = _currentYGridStart; i < panalChart.Size.Width; i += _pixelPer * _lineDifference )
				_g.DrawLine( gridPen, i, 0, i, panalChart.Size.Height );

			Pen axisPen = new Pen( _axisColor );

			_g.DrawLine( axisPen, 0, (int)( panalChart.Size.Height / 2 ), panalChart.Size.Width, (int)( panalChart.Size.Height / 2 ) );

			axisPen.Dispose();
			gridPen.Dispose();
		}

		private void DrawChart()
		{
			PostInitChart();

			Pen abovePen = new Pen( _aboveColor );
			Pen underPen = new Pen( _underColor );

			int halfHeight = panalChart.Size.Height / 2;
			switch( _openType )
			{
				case ChartControlOpenType.Bar:
					for( int i = _values.Length - _currentNumberOfValues; i < _values.Length; ++i )
					{
						if( _values[ i ] > 0 )
						{
							_g.DrawLine( abovePen, _values.Length - i - 1, halfHeight - 1, _values.Length - i - 1, halfHeight - _values[ i ] );
						}
						else if( _values[ i ] < 0 )
						{
							_g.DrawLine( underPen, _values.Length - i - 1, halfHeight - 1, _values.Length - i - 1, halfHeight - _values[ i ] );
						}
					}
					break;

				case ChartControlOpenType.Graph:
					for( int i = _values.Length - _currentNumberOfValues; i < _values.Length; ++i )
					{
						if( _values[ i ] >= 0 )
						{
							if( IntCompare( _values[ i ], _values[ i - 1 ] ) > 0 )
							{
								_g.DrawLine( underPen, ( _values.Length - i ) * 2, halfHeight - _values[ i - 1 ], ( _values.Length - i ) * 2 - 1, halfHeight );
								_g.DrawLine( abovePen, ( _values.Length - i ) * 2 - 1, halfHeight, ( _values.Length - i - 1 ) * 2, halfHeight - _values[ i ] );
							}
							else
							{
								_g.DrawLine( abovePen, ( _values.Length - i ) * 2, halfHeight - _values[ i - 1 ], ( _values.Length - i - 1 ) * 2, halfHeight - _values[ i ] );
							}
						}
						// _values[ i ] < 0
						else
						{
							if( IntCompare( _values[ i ], _values[ i - 1 ] ) < 0 )
							{
								_g.DrawLine( abovePen, ( _values.Length - i ) * 2, halfHeight - _values[ i - 1 ], ( _values.Length - i ) * 2 - 1, halfHeight );
								_g.DrawLine( underPen, ( _values.Length - i ) * 2 - 1, halfHeight, ( _values.Length - i - 1 ) * 2, halfHeight - _values[ i ] );
							}
							else
							{
								_g.DrawLine( underPen, ( _values.Length - i ) * 2, halfHeight - _values[ i - 1 ], ( _values.Length - i - 1 ) * 2, halfHeight - _values[ i ] );
							}
						}
					}

					break;
			}

			underPen.Dispose();
			abovePen.Dispose();
		}

		public int IntCompare( float num1, float num2 )
		{
			if( num1 >= 0 && num2 >= 0 )
				return 0;

			if( num1 < 0 && num2 < 0 )
				return 0;

			if( num1 >= 0 && num2 < 0 )
				return 1;

			if( num1 < 0 && num2 >= 0 )
				return -1;

			return 0;
		}

		private void panalChart_Paint( object sender, PaintEventArgs e )
		{
			if( null == panalChart )
				return;

			OnResize( new EventArgs() );
		}

		protected override void OnResize( EventArgs e )
		{
			base.OnResize( e );

			if( null == panalChart )
				return;

			if( 0 == Size.Width || 0 == Size.Height )
				return;

			if( 0 == _currentSize.Height && 0 == _currentSize.Width )
			{
				_currentSize = Size;
				return;
			}


			RecalculateSize();
			_currentSize = Size;
		}

		private void RecalculateSize()
		{
			if( 0 == _currentSize.Width || 0 == _currentSize.Height )
				return;

			if( null == _values )
				return;

			_maximum = panalChart.Height / 2;
			_minimum = -panalChart.Height / 2;

			float sizeChange = Size.Height / _currentSize.Height;
			if( 0 != Size.Height )
				_valueMultiplier = sizeChange;

			float[] newValues = new float[ Size.Width ];

			for( int i = _values.Length - 1, j = newValues.Length - 1; ( i >= 0 ) && ( j >= 0 ); --i, --j )
			{
				if( sizeChange != 0 )
					newValues[ j ] = _values[ i ] * sizeChange;
			}

			_values = newValues;
			_g.Dispose();

			_g = panalChart.CreateGraphics();
			DrawChart();
		}

		public void RefreshControl()
		{
			PostInitChart();
			DrawChart();
		}

		public void AddValue( float value )
		{
			if( 0 != _minimum && 0 != _maximum )
			{
				if( value * _valueMultiplier > _maximum || value * _valueMultiplier < _minimum )
					return;
			}

			for( int i = 0; i < _values.Length - 1; ++i )
				_values[ i ] = _values[ i + 1 ];

			_values[ _values.Length - 1 ] = value * _valueMultiplier;

			if( _currentNumberOfValues < _values.Length )
				++_currentNumberOfValues;

			if( _currentYGridStart < _pixelPer * _lineDifference - 1 )
			{
				switch( _openType )
				{
					case ChartControlOpenType.Bar:
						++_currentYGridStart;
						break;
					case ChartControlOpenType.Graph:
						_currentYGridStart += 2;
						break;
				}
			}
			else
			{
				_currentYGridStart = 0;
			}

			DrawChart();
		}
	}
}
