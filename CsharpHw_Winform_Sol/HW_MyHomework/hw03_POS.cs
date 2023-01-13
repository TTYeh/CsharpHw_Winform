using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyHomework
{
    public partial class hw03_POS : Form
    {
        // 菜單產品-價格
        public List<Product> ProductMenu { get; private set; }
        // 訂單產品-數量
        public Dictionary<string, int> CustomerOrder { get; private set; }

        public decimal TotalAmount { get; private set; }

        public hw03_POS()
        {
            InitializeComponent();
            this.Load += Hw03_POS_Load;
        }

        private void Hw03_POS_Load(object sender, EventArgs e)
        {
            // 初始化
            // 菜單只能新增不能減少。好爛的POS
            InitPOS();
        }
        public void InitPOS() 
        {
            // 屬性初始化
            this.ProductMenu = new List<Product>
                    {
                        new Product{ Name = "Beer" , Description = "啤酒",  UnitPrice = 120},
                        new Product{ Name = "Tequila" , Description = "龍舌蘭",  UnitPrice = 180},
                        new Product{ Name = "Whisky" , Description = "威士忌",  UnitPrice = 350},
                        new Product{ Name = "Wine" , Description = "紅酒",  UnitPrice = 320},
                    };
            this.CustomerOrder = new Dictionary<string, int>
                    {
                        { "Beer" ,0},
                        { "Tequila" ,0},
                        { "Whisky" ,0},
                        { "Wine" ,0},
                    };
            TotalAmount = 0;

            // 顯示初始化
            UpdateDisplay();
        }

        private void AddProductOnce(string filterName) {
            var linqPrice = ProductMenu.SingleOrDefault(a => a.Name == filterName);
            if (linqPrice.UnitPrice == 0) { return; } // 感覺資料型態應該不會出事還是擋心安一下
            TotalAmount += Convert.ToInt32(linqPrice.UnitPrice); // 加入產品的總金額
            CustomerOrder[filterName] = CustomerOrder[filterName] + 1;// 訂單數量
        }


        private void buttonBeer_Click(object sender, EventArgs e)
        {
            AddProductOnce("Beer");
            UpdateDisplay();

            // 注意:如果linq是Single回傳，再foreach會炸linq語法執行21次
            //foreach (var price in linqPrice)
            //{
            //    if (price == null) { return; }
            //    TotalAmount += Convert.ToInt32(price); // 總金額
            //    CustomerOrder["Beer"] = CustomerOrder["Beer"] + 1;// 訂單數量
            //}

            // 可能where條件有多個值 牙敗
            //var linqPrice = from list in this.ProductMenu
            //                where list.Name == "Beer"
            //                select list.UnitPrice;
        }

        public void UpdateDisplay()
        {
            textBoxShoppingList.Text = GenerateOrderInfo();
            textBoxTotalPrice.Text = $"NT$ {TotalAmount}" ;

        }
        public string GenerateOrderInfo()
        {
            string result = string.Empty;
            bool noOrderFlag = false;
            foreach(var item in ProductMenu)
            {
                if (CustomerOrder[item.Name] < 1) continue;
                noOrderFlag = true;
                result += $"{item.Description}{item.Name}× {CustomerOrder[item.Name]} ,共NT$ {CustomerOrder[item.Name] * item.UnitPrice} \r\n";
            }
            return noOrderFlag ? result : "尚未點餐";
        }


        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            string message = $"總金額: {String.Format("{0:C0}", TotalAmount)}";
            ShowMegBox4Payment(message);
        }
        private void ShowMegBox4Payment(string msg) 
        {
            const string caption = "確認付款";

            if (TotalAmount == 0)
            {
                string message = $"尚未點餐";
                MessageBox.Show(message, caption,
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
            else
            {
                string message = msg;
                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo);
            }
        }


        private void buttonTequila_Click(object sender, EventArgs e)
        {
            AddProductOnce("Tequila");
            UpdateDisplay();
        }

        private void buttonWhisky_Click(object sender, EventArgs e)
        {
            AddProductOnce("Whisky");
            UpdateDisplay();
        }

        private void buttonWineNT_Click(object sender, EventArgs e)
        {
            AddProductOnce("Wine");
            UpdateDisplay();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            InitPOS();
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            decimal percentOff = 0.9M; // 折扣10%
            string message = $"總金額: {String.Format("{0:C0}", TotalAmount)} \n" +
                $"折扣後金額: NT$ {String.Format("{0:C0}", TotalAmount * percentOff)}";
            ShowMegBox4Payment(message);       
        }
    }

    public class Product { 
    
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }

    }
}
