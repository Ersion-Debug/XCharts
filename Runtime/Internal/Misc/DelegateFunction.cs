using System.Collections.Generic;
using UnityEngine.UI;

namespace XCharts.Runtime
{
    /// <summary>
    /// The delegate function for LabelStyle‘s formatter.
    /// |SerieLabel的formatter自定义委托。
    /// </summary>
    /// <param name="dataIndex">数据索引</param>
    /// <param name="value">数值</param>
    /// <returns>最终显示的文本内容</returns>
    public delegate string LabelFormatterFunction(int dataIndex, double value, string category);
    public delegate float AnimationDelayFunction(int dataIndex);
    public delegate float AnimationDurationFunction(int dataIndex);
    /// <summary>
    /// 获取标记大小的回调。
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public delegate float SymbolSizeFunction(List<double> data);
    public delegate void CustomDrawGaugePointerFunction(VertexHelper vh, int serieIndex, int dataIndex, float currentAngle);
}