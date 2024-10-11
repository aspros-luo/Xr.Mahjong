using Aspros.Base.Framework.Domain;

namespace Xr.Mahjong.Domain
{
    public class CategoryPropertyValue : BasicEntity, IAggregateRoot
    {
        public long Id { get; protected set; }

        /// <summary>
        /// 类目 Id
        /// </summary>
        public long CategoryId { get; protected set; }

        /// <summary>
        /// 属性 iD
        /// </summary>
        public long PropertyId { get; protected set; }

        /// <summary>
        /// 属性名
        /// </summary>
        public long ValueId { get; protected set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string ValueName { get; protected set; } = string.Empty;
    }
}
