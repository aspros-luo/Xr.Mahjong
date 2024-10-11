using Aspros.Base.Framework.Domain;

namespace Xr.Mahjong.Domain
{
    public class User : BasicEntity, IAggregateRoot
    {
        public long Id { get; private set; }

    }
}
