using System;
using System.Threading;
namespace CabconPMP.BenchSimulator
{

    public sealed class Bench
    {
        private static readonly Lazy<Bench> _instance =
            new Lazy<Bench>(() => new Bench());

        private Timer _timer;

        public static Bench Instance
        {
            get { return _instance.Value; }
        }

        // Voltage
        public double UA { get; private set; }
        public double UB { get; private set; }
        public double UC { get; private set; }

        // Current
        public double IA { get; private set; }
        public double IB { get; private set; }
        public double IC { get; private set; }

        public double IMax { get; private set; }
        public bool IsImax { get; private set; }

        // Other Parameters
        public double PHI { get; private set; }
        public double FREQ { get; private set; }
        public string Waveform { get; private set; }
        public string PhaseSeq { get; private set; }

        // Environmental Parameters
        public double Temperature { get; private set; } = 0.0;
        public double Humidity { get; private set; } = 0.0;

        private Bench()
        {
            LoadValues();

            // Refresh every 5 seconds
            _timer = new Timer(UpdateValues, null, 5000, 5000);
        }

        private void UpdateValues(object state)
        {
            LoadValues();
        }

        //private void LoadValues()
        //{
        //    // Hardcoded simulation values

        //    UA = 230.5;
        //    UB = 229.8;
        //    UC = 231.1;

        //    IA = 10.5;
        //    IB = 10.3;
        //    IC = 10.7;

        //    IMax = 10.7;
        //    IsImax = true;

        //    PHI = 29.5;
        //    FREQ = 50.02;

        //    Waveform = "Sine";
        //    PhaseSeq = "RYB";
        //}

        public void Stop()
        {
            if (_timer != null)
            {
                _timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }

        public void Start()
        {
            if (_timer != null)
            {
                _timer.Change(5000, 5000);
            }
        }


        private readonly Random _random = new Random();

        private void LoadValues()
        {
            UA = 229 + _random.NextDouble() * 3;
            UB = 229 + _random.NextDouble() * 3;
            UC = 229 + _random.NextDouble() * 3;

            IA = 10 + _random.NextDouble();
            IB = 10 + _random.NextDouble();
            IC = 10 + _random.NextDouble();

            IMax = Math.Max(IA, Math.Max(IB, IC));
            IsImax = true;

            PHI = 30 + _random.NextDouble();
            FREQ = 49.95 + _random.NextDouble() * 0.1;


            Temperature = 20 + _random.NextDouble() * 10;
            Humidity = 30 + _random.NextDouble() * 50;

            Waveform = "Sine";
            PhaseSeq = "RYB";
        }
    }
}