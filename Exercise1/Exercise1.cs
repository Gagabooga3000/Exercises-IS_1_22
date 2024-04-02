using System;

namespace Exercise1
{
    class Engine
      {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int EngineState;

        public void Start()
        {
            Console.WriteLine("Start");
            EngineState = StateStopped;
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
            EngineState = StateStarted;
        }

        public string GetState()
        {
            return (EngineState == StateStopped) ? "STOPPED" : "STARTED";
        }
    }
}
