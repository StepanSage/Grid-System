using System;

namespace Code.Service
{
    public interface ILisener
    {
        public event Action CallBack;
    }
}
