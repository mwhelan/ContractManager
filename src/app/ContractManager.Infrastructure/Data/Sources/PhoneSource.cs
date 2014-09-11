using System;
using System.Globalization;
using AutoPoco.Engine;

namespace ContractManager.Infrastructure.Data.Sources
{
    public class PhoneSource : DatasourceBase<string>
    {
        public const string DefaultFormat = "({0}) {1}-{2}";

        private static readonly Random _random = new Random();
        private readonly string _format;

        public PhoneSource()
            : this(DefaultFormat)
        { }

        public PhoneSource(string format)
        {
            _format = format ?? DefaultFormat;
        }


        public override string Next(IGenerationSession context)
        {
            string areaCode = _random.Next(100, 999).ToString(CultureInfo.InvariantCulture);
            string exchange = _random.Next(100, 999).ToString(CultureInfo.InvariantCulture);
            string number = _random.Next(1, 9999).ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');

            return string.Format(_format, areaCode, exchange, number);
        }

    }
}