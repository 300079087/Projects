using System;
namespace TimerPro.Custom
{
	public class TimerLogic
	{
		private int _iSec;
		private int _iMin;
		private int _iHour;

		public TimerLogic()
		{
			Reset();
		}

		public void SetTickCounter()
		{
			_iSec++;
			if (_iSec == 60)
			{
				_iMin++;
				_iSec = 0;
			}
			if (_iMin == 60)
			{
				_iHour++;
				_iMin = 0;
			}
		}

		public void Reset()
		{
            _iSec = 0;
            _iMin = 0;
            _iHour = 0;
        }

		public string GetFormatedString()
		{
			return _iHour.ToString().PadLeft(2, '0') + ":" + _iMin.ToString().PadLeft(2, '0') + ":" + _iSec.ToString().PadLeft(2, '0'); ;
		}


	}
}

