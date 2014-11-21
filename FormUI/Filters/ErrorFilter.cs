using System;

namespace FormUI.Filters
{
    /// <summary>
    ///     ����ɸѡ�������
    /// </summary>
    public class ErrorFilter : Filter
    {
        private const string name = "ȷ��";

        public ErrorFilter(Filter next)
            : base(next)
        {
        }

        public override string Phone { get; protected set; }
        public override DateTime Time { get; set; }
        public override string Context { get; set; }
        public override string Name { get; set; }

        public override Filter Run()
        {
            return null;
        }
    }
}