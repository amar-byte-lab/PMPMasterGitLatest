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

        public double IMax { get; private set; }
        public bool IsImax { get; private set; }

        // Other Parameters
        public double FREQ { get => _freq; private set => _freq = Math.Round(value, 2); }
        private double _freq;

        public string Waveform { get; private set; }
        public string PhaseSeq { get; private set; }

        // Environmental Parameters
        public double Temperature { get => _temperature; private set => _temperature = Math.Round(value, 2); }
        private double _temperature = 0.0;
        public double Humidity { get => _humidity; private set => _humidity = Math.Round(value, 2); }
        private double _humidity = 0.0;


        private double _ua;
        private double _ub;
        private double _uc;
        private double _ia;
        private double _ib;
        private double _ic;
        private double _phi;

        public double UA
        {
            get => _ua;
            set
            {
                _ua = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double UB
        {
            get => _ub;
            set
            {
                _ub = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double UC
        {
            get => _uc;
            set
            {
                _uc = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double IA
        {
            get => _ia;
            set
            {
                _ia = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double IB
        {
            get => _ib;
            set
            {
                _ib = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double IC
        {
            get => _ic;
            set
            {
                _ic = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double PHI
        {
            get => _phi;
            set
            {
                _phi = Math.Round(value, 2);
                CalculatePower();
            }
        }

        public double ApparentPower { get; private set; } //(S) => [VA]
        public double ActivePower { get; private set; } //(P) => [W]
        public double ReactivePower { get; private set; } //(Q) => [VAR]

        private Bench()
        {
            LoadValues();

            // Refresh every 5 seconds
            _timer = new Timer(UpdateValues, null, 5000, 5000);
        }

        private void CalculatePower()
        {
            double voltage = (UA + UB + UC) / 3.0;
            double current = (IA + IB + IC) / 3.0;
            double phi = PHI * Math.PI / 180.0;

            ApparentPower = Math.Round(Math.Sqrt(3) * voltage * current, 2);
            ActivePower = Math.Round(ApparentPower * Math.Cos(phi), 2);
            ReactivePower = Math.Round(ApparentPower * Math.Sin(phi), 2);
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