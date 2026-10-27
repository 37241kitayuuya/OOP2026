using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter;
//抽象クラス
public abstract class ConverterBase {
    public abstract bool Ismyunit(string name)=>
        name.ToLower()== "meter" || name == UnitName;
    //メートルとの比率（この比率を掛けるとメートルに変換できる）
    protected abstract double Raito { get; }

    //距離の単位名（例えば、"メートル"、"フィートなど"）
    public abstract string UnitName { get; }

    //メートルからの変換
    public double FromMeter(double meter) => meter / Raito;

    //メートルへの変換
    public double ToMeter(double feet) => feet * Raito;
    }

