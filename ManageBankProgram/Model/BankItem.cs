using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBankProgram.Model
{
    public class BankItem
    {
        private String _itemId;
        private String _itemDate;           // Date will be string but will be appear as Date if possible according to design
        private String _itemDescription;
        private double _itemAmountSpent;
        private Boolean _itemSign;

        public string ItemId { get => _itemId; set => _itemId = value; }
        public string ItemDate { get => _itemDate; set => _itemDate = value; }
        public string ItemDescription { get => _itemDescription; set => _itemDescription = value; }
        public double ItemAmountSpent { get => _itemAmountSpent; set => _itemAmountSpent = value; }
        public bool ItemSign { get => _itemSign; set => _itemSign = value; }

        public BankItem(string itemId, string itemDate, string itemDescription, double itemAmountSpent, bool itemSign)
        {
            ItemId = itemId;
            ItemDate = itemDate;
            ItemDescription = itemDescription;
            ItemAmountSpent = Math.Round(itemAmountSpent, 2);
            ItemSign = itemSign;
        }

        public BankItem()
        {
        }

        public string ToTextString()
        {
            return _itemId + " " + _itemDate + " " + 
                _itemDescription + " " + 
                Math.Round(_itemAmountSpent,2).ToString() + " "
                + (_itemSign? "+" : "-" ) + " ";
        }
        
    }
}
