using FruitShop.Shared;
using FruitShop.Shared.Entities;


namespace FruitShop.Entities.Concrete
{
    public class  Message : EntityBase, IEntity
    {
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public string Email { get; set; }
        public int MessageStatusId { get; set; }

        #region relations

        public MessageStatus MessageStatus{ get; set; }

        #endregion

    }
}
