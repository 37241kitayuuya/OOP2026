using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter;

public class Meterconverter : ConverterBase {
    protected override double Raito => 1;name.Equals("meter",StringComparison.CurrentCultureIgnoreCase|| name==UnitName ) == ;
    public override string UnitName => "メートル";

    public class Feetconverter : ConverterBase {
        protected override double Raito => 0.3048;
        public override string UnitName => "フィート";

        public class Inchconverter : ConverterBase {
            protected override double Raito => 0.0254;
            public override string UnitName => "インチ";

            public class Yardconverter : ConverterBase {
                protected override double Raito => 0.9144;
                public override string UnitName => "ヤード";
            }
        }
    }
}
