using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        //プロパティ（ｐ114）
        public int Year { get; init; }
        public int Month { get; init; }
        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }
        //5.1.2（ｐ116）
        //設定されている西暦が21世紀かを判断
        //Yearが2001～2100年の間ならtrue,それ以外ならfalseを返す
        public bool Is21Century => 2001 <= Year && Year <= 2100;
        //5.1.3
        public YearMonth Add0neMonth() {
            {
                if (Month == 12) {
                    return new YearMonth(Year + 1, 1);
                }

                return new YearMonth(Year, Month + 1);
            }
        }

        //5.1.4
        public override string ToString() => $"{Year}年{Month}月";
            return base.ToString();
        }
    }

