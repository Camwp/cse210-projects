class Product
    {
        private string name;
        private string productId;
        private double price;
        private int quantity;

        public Product(string pName, string pProductId, double pPrice, int pQuantity)
        {
            name = pName;
            productId = pProductId;
            price = pPrice;
            quantity = pQuantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetProductId()
        {
            return productId;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public double GetTotalPrice()
        {
            return price * quantity;
        }
    }