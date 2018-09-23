using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Net;
using System.IO;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace ParserLib
{
    //enum typeOfGoods
    //{
    //    WomanSneakers = "Кеды женские",
    //    ManSneakers = "Кеды мужские",
    //    WomanBoots = "Ботинки женские",
    //    ManBoots = "Ботинки мужские",
    //    WomanHighBoots = "Сапоги женские",
    //    ManHighBoots = "Сапоги мужские",
    //    Trainers = "Кроссовки женские",
    //    Trainers = "Кроссовки мужские"
    //}
    public class MarketItem
    {
        #region Properties
        /// <summary>
        /// Артикул ( номер по порядку)
        /// </summary>
        public int Model { get; set; }
        /// <summary>
        /// Название Модели
        /// </summary>
        public string Name { get; set; } // сюда название модели + значение из А1 // //h4/a
                                         /// <summary>
                                         /// Описание, по умолчанию, <p><br></p>
                                         /// </summary>
        public string Description { get; set; } //<p><br></p>
                                                /// <summary>
                                                /// Название модели тоже
                                                /// </summary>
        public string Meta_title { get; set; } //сюда название модели + значение из А1
                                               /// <summary>
                                               /// транскрипция
                                               /// </summary>
        public string SEO_url { get; set; } //транскрипция с "-" вместо пробелов
                                            /// <summary>
                                            /// Количество пар размера
                                            /// </summary>
        public string Quantity { get; set; } //количество пар размера
                                             /// <summary>
                                             /// Остаток
                                             /// </summary>
        public string Out_stock_status { get; set; } //остаток
                                                     /// <summary>
                                                     ///Диапозон размеров 
                                                     /// </summary>
        public string Option { get; set; } //сапоги женские 30-40
                                           /// <summary>
                                           /// По-умолчанию radio
                                           /// </summary>
        public string Option_type { get; set; } //radio
                                                /// <summary>
                                                /// Размер
                                                /// </summary>
        public string Option_value { get; set; } //размер
                                                 /// <summary>
                                                 /// Цена-ручками ставится
                                                 /// </summary>
        public string Price { get; set; } //цена(проставляется в ручную)
                                          /// <summary>
                                          /// Марка (Адидас, Найк,...)
                                          /// </summary>
        public string Manufacturer { get; set; } //производитель (Adidas)
                                                 /// <summary>
                                                 /// Картинка
                                                 /// </summary>
        public string Main_image { get; set; } //Главная картинка
                                               /// <summary>
                                               /// 
                                               /// </summary>

        public List<MarketItem> ChildrenItems = new List<MarketItem>();
        public string Error { get; internal set; }
        #region DONTUSE?
        //public string Meta_description { get; set; } //
        //public string Meta_keywords { get; set; } //
        //public string Tags { get; set; } //
        //public string SKU { get; set; } //
        //public string EAN { get; set; } //
        //public string UPC { get; set; } //
        //public string JAN { get; set; } //
        //public string MPN { get; set; } //
        //public string ISBN { get; set; } //
        //public string Minimum { get; set; } //
        //public string Subtract { get; set; } //
        //public string Option_required { get; set; } //
        //public string Option_subtract { get; set; } //
        //public string Option_image { get; set; } //
        //public string Option_price_prefix { get; set; } //
        //public string Option_points_prefix { get; set; } //
        //public string Option_weight_prefix { get; set; } //
        //public string Option_SKU_Options_Boost { get; set; } //
        //public string Option_image_Options_Boost { get; set; } //
        //public string Spe_Customer_Group { get; set; } //
        //public string Spe_Priority { get; set; } //
        //public string Spe_Price { get; set; } //
        //public string Spe_Date_start { get; set; } //
        //public string Spe_Date_end { get; set; } //       
        //public string Dis_Customer_Group_1 { get; set; } //
        //public string Dis_Quantity_1 { get; set; } //
        //public string Dis_Priority_1 { get; set; } //
        //public string Dis_Price_1 { get; set; } //
        //public string Dis_Date_start_1 { get; set; } //
        //public string Dis_Date_end_1 { get; set; } //
        //public string Dis_Customer_Group_2 { get; set; } //
        //public string Dis_Quantity_2 { get; set; } //
        //public string Dis_Priority_2 { get; set; } //
        //public string Dis_Price_2 { get; set; } //
        //public string Dis_Date_start_2 { get; set; } //
        //public string Dis_Date_end_2 { get; set; } //
        //public string Dis_Customer_Group_3 { get; set; } //
        //public string Dis_Quantity_3 { get; set; } //
        //public string Dis_Priority_3 { get; set; } //
        //public string Dis_Price_3 { get; set; } //\
        //public string Dis_Date_start_3 { get; set; } //
        //public string Dis_Date_end_3 { get; set; } //        
        //public string Cat_level_1 { get; set; } //
        //public string Cat_level_2 { get; set; } //
        //public string Cat_level_3 { get; set; } //
        //public string Cat_level_4 { get; set; } //
        //public string Cat_level_5 { get; set; } //
        //public string Image_2 { get; set; } //
        //public string Image_3 { get; set; } //
        //public string Image_4 { get; set; } //
        //public string Image_5 { get; set; } //
        //public string Date_available { get; set; } //
        //public string Points { get; set; } //
        //public string Points_Default { get; set; } //
        //public string Requires_shipping { get; set; } //
        //public string Location { get; set; } //
        //public string Tax_class { get; set; } //
        //public string Sort_order { get; set; } //
        //public string Store { get; set; } //
        //public string Status { get; set; } //
        //public string Class_weight { get; set; } //
        //public string Weight { get; set; } //
        //public string Class_length { get; set; } //
        //public string Length { get; set; } //
        //public string Width { get; set; } //
        //public string Height { get; set; } //
        //public string Attr_Group_1 { get; set; } //
        //public string Attribute_1 { get; set; } //
        //public string Attribute_value_1 { get; set; } //
        //public string Attr_Group_2 { get; set; } //
        //public string Attribute_2 { get; set; } //
        //public string Attribute_value_2 { get; set; } //
        //public string Attr_Group_3 { get; set; } //
        //public string Attribute_3 { get; set; } //
        //public string Attribute_value_3 { get; set; } //
        //public string Attr_Group_4 { get; set; } //
        //public string Attribute_4 { get; set; } //
        //public string Attribute_value_4 { get; set; } //
        //public string Attr_Group_5 { get; set; } //
        //public string Attribute_5 { get; set; } //
        //public string Attribute_value_5 { get; set; } //
        //public string Attr_Group_6 { get; set; } //
        //public string Attribute_6 { get; set; } //
        //public string Attribute_value_6 { get; set; } //
        //public string Filter_Group_1 { get; set; } //
        //public string Filter_Gr1_filter_1 { get; set; } //
        //public string Filter_Gr1_filter_2 { get; set; } //
        //public string Filter_Gr1_filter_3 { get; set; } //
        //public string Filter_Group_2 { get; set; } //
        //public string Filter_Gr2_filter_1 { get; set; } //
        //public string Filter_Gr2_filter_2 { get; set; } //
        //public string Filter_Gr2_filter_3 { get; set; } //
        //public string Filter_Group_3 { get; set; } //
        //public string Filter_Gr3_filter_1 { get; set; } //
        //public string Filter_Gr3_filter_2 { get; set; } //
        //public string Filter_Gr3_filter_3 { get; set; } //
        //public string Layout { get; set; } //
        #endregion  
        #endregion
        public MarketItem()
        {

        }

        public MarketItem(int Model, string Name, string Description, string Meta_title, string SEO_url, string Quantity, string Out_stock_status,
            string Option, string Option_type, string Option_Value, string Price, string Manufacturer, string MainImage)
        {
            this.Model = Model;
            this.Name = Name;
            this.Description = Description;
            this.Meta_title = Meta_title;
            this.SEO_url = SEO_url;
            this.Quantity = Quantity;
            this.Out_stock_status = Out_stock_status;
            this.Option = Option;
            this.Option_type = Option_type;
            this.Option_value = Option_value;
            this.Price = Price;
            this.Manufacturer = Manufacturer;
            this.Main_image = Main_image;
        }
        public override string ToString()
        {
            return Model + "; " + Name + " " + Model + "; " + Description + "; " + Meta_title + " " + Model + "; " +
                SEO_url + "; " + Quantity + "; " + Out_stock_status + "; " + Option + "; " + Option_type + "; " +
                Option_value + "; " + Price + "; " + Manufacturer;
        }
        public override bool Equals(object obj)
        {
            //if()
            //{

            //}
            return base.Equals(obj);
        }

        public Image GetPhoto()
        {
            using (WebClient wClient = new WebClient())
            {
                byte[] imageByte = wClient.DownloadData(Main_image);

                using (MemoryStream ms = new MemoryStream(imageByte, 0, imageByte.Length))
                {
                    ms.Write(imageByte, 0, imageByte.Length);
                    return Image.FromStream(ms, true);
                }
            }
        }

    }

    public class MarketItems : List<MarketItem>
    {

        public MarketItems()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static MarketItems Import(string filename)
        {
            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(filename)))
            {


                var Worksheet = xlPackage.Workbook.Worksheets.First(); //select sheet here
                var totalRows = Worksheet.Dimension.End.Row;
                var totalColumns = Worksheet.Dimension.End.Column;

                //  var sb = new StringBuilder(); //this is your your data
                Dictionary<string, List<string>> Colls = new Dictionary<string, List<string>>();
                for (int col = 1; col <= totalColumns; col++)
                {
                    var Column = Worksheet.Cells[1, col, totalRows, col].
                        Select(x => x.Value == null ? " " : x.Value.ToString()).ToList();
                    Colls.Add(Column.First(), Column);
                }

                MarketItems result = new MarketItems();

                for (int i = 1; i < Colls["*Model"].Count - 1; i++)
                {
                    try
                    {
                        if ((Colls["*Model"][i] == Colls["*Model"][i - 1]) && (result.Last() != null))
                        {
                            result.Last().ChildrenItems.Add(new MarketItem
                            {
                                Model = Convert.ToInt32(Colls["*Model"][i]),
                                Name = Colls["*Name"][i],
                                Description = result.Last().Description,
                                Meta_title = result.Last().Meta_title,
                                SEO_url = result.Last().SEO_url,
                                Quantity = Colls["Quantity"][i],
                                Out_stock_status = result.Last().Out_stock_status,
                                Option = result.Last().Option,
                                Option_value = Colls["Option value"][i],
                                Price = Colls["Price"][i],
                                Manufacturer = result.Last().Manufacturer,
                                Main_image = result.Last().Main_image
                            });
                        }
                        else
                        {
                            result.Add(new MarketItem
                            {
                                Model = Convert.ToInt32(Colls["*Model"][i]),
                                Name = Colls["*Name"][i],
                                Description = Colls["Description"][i],
                                Meta_title = Colls["Meta title"][i],
                                SEO_url = Colls["SEO url"][i],
                                Quantity = Colls["Quantity"][i],
                                Out_stock_status = Colls["Out stock status"][i],
                                Option = Colls["Option"][i],
                                Option_value = Colls["Option value"][i],
                                Price = Colls["Price"][i],
                                Manufacturer = Colls["Manufacturer"][i],
                                Main_image = Colls["Main image"][i]
                            });
                        }
                    }
                    catch
                    {
                        result.Add(new MarketItem());
                    }
                }


                return result;
            }

        }


        public static void Export(string filename, MarketItems item)
        {
            MarketItems items = new MarketItems();
            foreach(var a in item)
            {
                items.Add(a);
                if(a.ChildrenItems.Count != 0)
                {
                    foreach (var b in a.ChildrenItems)
                    {
                        items.Add(b);
                    }
                }
            }

            using (ExcelPackage xlPackage = new ExcelPackage(new FileInfo(filename)))
            {
                var Worksheet = xlPackage.Workbook.Worksheets.First(); //select sheet here
                var totalRows = Worksheet.Dimension.End.Row;
                var totalColumns = Worksheet.Dimension.End.Column;
                Dictionary<string, List<string>> Colls = new Dictionary<string, List<string>>();
                for (int col = 1; col <= totalColumns; col++)
                {
                    if(Worksheet.Cells[1,col].Value.ToString() == "*Model")
                    {
                        for(int i = 0; i<items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Model;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "*Name")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Name;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Description")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Description;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Meta title")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[ + 2, col, i + 2, col].Value = items[i].Meta_title;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "SEO url")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].SEO_url;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Quantity")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Quantity;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Out stock status")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Out_stock_status;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Option")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Option;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Option value")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Option_value;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Price")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Price;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Manufacturer")
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = items[i].Manufacturer;
                        }
                    }
                    if (Worksheet.Cells[1, col].Value.ToString() == "Main image")
                    {// "catalog/tovar/" + a.Model+".jpg"
                     
                        for (int i = 0; i < items.Count; i++)
                        {
                            Worksheet.Cells[i + 2, col, i + 2, col].Value = "catalog/tovar/" + items[i].Model+".jpg";
                        }
                    }
                    xlPackage.Save();
                }
            }
        }

        public static List<int> ConvertList(List<string> list)
        {
            List<int> IntOpt = new List<int>();
            foreach (var item in list)
            {
                IntOpt.Add(Convert.ToInt32(item));
            }
            return IntOpt;
        }

        public static string Option(List<int> list)
        {

            if (list.Count == 1)
            {
                return list.FirstOrDefault().ToString();
            }
            else
            {
                return list.Min() + "-" + list.Max();
            }
        }

        public static int PageCount(string url)
        {
            var doc = new HtmlWeb().Load(url + "/goods.php");
            return Convert.ToInt32(Regex.Match(doc.DocumentNode.SelectSingleNode("//div[@class='sxy']/form").InnerText,
                                               @"(\d*)(页&n)").Groups[1].Value);
        }

        public static int GoodsInPage(string url)
        {
            return new HtmlWeb().Load(url + "/goods.php").DocumentNode.SelectNodes("//div[@class='ernr']").Count();
        }
        private string Manuf(string name)
        {
            string res = String.Empty;
            string[] vs = new string[]
            {
                "Nike","Puma","Reebok","Timberland","UGG","Vans","Converse","New Balance","Jordan","Asics","Adidas" };
            foreach (var a in vs)
            {
                if (name.ToLower().Contains(a.ToLower()))
                {
                    res = a;
                    break;
                }

            }
            return res;

        }

        public void ParseFrom(string url)
        {

            try
            {
                var doc = new HtmlWeb().Load(url + "/goods.php");
                int pageCount = MarketItems.PageCount(url);
                //проверка по пагинации
                for (int page = 1; page <= pageCount; page++)
                {
                    doc = new HtmlWeb().Load(url + "/goods.php?cid=5&page=" + page); //текущая страница
                    var pageGoods = doc.DocumentNode.SelectNodes("//div[@class='ernr']/ul/li/div/h3/a").
                                                     Select(a => url + "/" + a.ChildAttributes("href").
                                                     FirstOrDefault().Value); //ссылки на все товары на странице
                    if (pageGoods.Count() == 0)
                    {
                        throw new Exception("Товары не найдены!\nВозможно, сайт поменял верстку. Требуется обновить ПО!");

                    }
                    else
                    {
                        foreach (var good in pageGoods.ToList())
                        {
                            MarketItem item = new MarketItem();//будем заполнять товар
                            try
                            {
                                var goodNode = new HtmlWeb().Load(good).DocumentNode.SelectSingleNode("//div[@class='cps']"); //html товара. отсюда и вытащим всё
                                var Options = MarketItems.ConvertList(goodNode.SelectNodes(".//div[@class='tabmen']/ul/li").Select(a => a.InnerText).ToList());
                                var Quantities = ConvertList(goodNode.SelectNodes(".//div[@id='tabconten']/ul/li").Select(a => a.InnerText.Replace("双", "")).ToList());//
                                item.Model = Count != 0 ? this.Max(a => a.Model) + 1 : 1;
                                item.Name = goodNode.SelectSingleNode(".//h6").InnerText + " " + item.Model;
                                item.Description = "<p><br></p>";
                                item.SEO_url = item.Name.Replace(" ", "-");
                                item.Out_stock_status = "";
                                item.Option_type = "radio";
                                item.Price = "";//сам вводит
                                item.Meta_title = item.Name;
                                item.Main_image = url + goodNode.SelectSingleNode(".//img").ChildAttributes("src").FirstOrDefault().Value;
                                /*TODO*/
                                item.Manufacturer = Manuf(item.Name);
                                item.Option = MarketItems.Option(Options);

                                //по парам
                                item.Quantity = Quantities.First().ToString();
                                item.Option_value = Options.First().ToString();
                                if (Options.Count == Quantities.Count)
                                {
                                    if (Options.Count > 1)
                                    {
                                        for (int i = 1; i < Options.Count; i++)
                                        {
                                            MarketItem child = new MarketItem();
                                            child.Model = item.Model;
                                            child.Name = item.Name;
                                            child.Description = "";
                                            child.Meta_title = "";
                                            child.SEO_url = "";
                                            child.Option = item.Option;
                                            child.Option_type = item.Option_type;
                                            child.Main_image = "";
                                            child.Quantity = Quantities[i].ToString();
                                            child.Option_value = Options[i].ToString();
                                            item.ChildrenItems.Add(child);
                                        }
                                    }
                                }
                                else throw new Exception();
                            }
                            catch (Exception exception)
                            {

                                item.Error = exception.Message.ToString();
                            }

                            Add(item);//после парсинга страницы добавляем элемент
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Произошла ошибка при попытке получить страницу по адресу: " + url + "\n\t\t" + e.Message + "\nПожалуйста, проверьте правильность ввода ресурса!");
            }
        }

        public async Task<bool> ParseAsync(string url)
        {
            await Task.Run(() => this.ParseFrom(url));
            return true;
        }
    }


}
