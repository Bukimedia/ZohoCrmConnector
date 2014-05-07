using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities.AuxEntities
{
    public class AuxProducts
    {
        /* Don't made it yet
         * 
         * public List<Products> List_Products { get; set; }
         * 
         * <FL val="Product Details">
         *     <product no="1">
         *         <FL val="Product Id">1122040000000090054</FL>
         *         <FL val="Product Name">
         *             <![CDATA[ Acer Ferrari 3200 Notebook Computer PC ]]>
         *         </FL>
         *         <FL val="Unit Price">2000.0</FL>
         *         <FL val="Quantity">2.0</FL>
         *         <FL val="Quantity in Stock">10.0</FL>
         *         <FL val="Total">3500.0</FL>
         *         <FL val="Discount">175.0</FL>
         *         <FL val="Total After Discount">3325.0</FL>
         *         <FL val="List Price">1750.0</FL>
         *         <FL val="Net Total">4023.25</FL>
         *         <FL val="Tax">698.25</FL>
         *         <FL val="Product Description">
         *             <![CDATA[ sdgdfgsdfg ]]>
         *         </FL>
         *     </product>
         *     <product no="2">...</product>
         * </FL>
         * 
         * */
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Unit_Price { get; set; }
        public string Total { get; set; }
        public string Discount { get; set; }
        public string Total_After_Discount { get; set; }
        public string List_Price { get; set; }
        public string Net_Total { get; set; }
        public string Tax { get; set; }
        public string Product_Description { get; set; }
    }
}
