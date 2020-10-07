using KODMARK_new.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KODMARK_new.Data
{
    public class KodmarkData
    {
        public KodmarkData()
        {
            singleProductModels = new List<SingleProductModel>()
            {
                new SingleProductModel()
                {
                    ProductId=1,
                    ProductName="WAX RIBBON",
                    Description="The Wax ribbon is compatible with all barcode printers. It can be used on many product labels. It is preferred because of its long-lasting printing durability and affordable price. Wax ribbon can print on all paper-based labels such as coated, vellum, fragile labels.",
                    Definition=" Wax ribbon is usually preferred on paper-based coated labels and vellum labels.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="waxRibon.png"},
                        new ProductImage(){ImagePath="wax2.jpg"},
                        new ProductImage(){ImagePath="wax3.jpg"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=2,
                    ProductName=" WAX-RESIN RIBBON",
                    Definition="   Used for printing on Polyethylene, Polypropylene, Data PE papers.",
                    Description="An ideal thermal transfer ribbon type, as opposed to wax ribbons, for high resolution barcode printers that are more durable and stain resistant than ribbons. Wax-resin ribbon, offering a high resistance against friction and external factors, can be printed on paper-based and synthetic materials. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="waxResin3.jpg"},
                        new ProductImage(){ImagePath="waxResin2.jpg"},
                        new ProductImage(){ImagePath="WaxResin1.jpg"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=3,
                    ProductName="RESIN RIBBON",
                    Definition=" Used for printing on Silvermat, Whitemat, Glosswhite,  Care Label  (Japon Akmaz) paper and cloth labels.",
                    Description="It is an ideal thermal transfer ribbon for all general-purpose, high-density, non-static printing applications that have to be long-lasting, resistant against heat, scratching and abrasion. Resin ribbon, which is resistant to the most extreme washing in textile prints, passes the alcohol test. It is possible to print on polyester, polyimide, polypropylene and polyethylene labels with resin ribbon.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="resin2.png"},
                        new ProductImage(){ImagePath="Resin1.png"},
                        new ProductImage(){ImagePath="resin3.png"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=4,
                    ProductName=" COLORED RIBBON",
                    Definition=" It can be applied anywhere wax, wax resin and resin ribbon are used.",
                    Description="It has the same feature with all ribbons and the only difference is their color. Vellum, coated and silvermat label can be safely applied to many surfaces such as PP, PE. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="rrenkliribon.jpg"},
                        new ProductImage(){ImagePath="renkliribon2.jpg"},
                        new ProductImage(){ImagePath="renkliribon3.png"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=5,
                    ProductName=" DATE CODING RIBBON",
                    Definition="  Production date, expiry (B.B.) date, serial number, lot number, batch number, operating code, barcode, qr code, logo and so on. It is used for overwriting information on the product. ",
                    Description="Usually used for printing date and lot number on packaging. The date coding foil is available in many colors, providing high adhesion in plastic-based packaging. Black and white are the most commonly used colors.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="tarihkodlama.jpg"},
                        new ProductImage(){ImagePath="tarihkodlama2.jpg"},
                        new ProductImage(){ImagePath="tarihkodlama3.png"}
                    }
                },
                 new SingleProductModel()
                {
                    ProductId=6,
                    ProductName="NEAR EDGE RIBBON",
                    Definition=" Used for printing in Near Edge printers on various materials such as Vellum, coated paper and some synthetics, glossy papers, etc.  ",
                    Description="Near edge ribbon can be printed at high speeds. Due to its high durability, it is used in many applications. Areas of application are not as wide as in resin ribbons. It is used in some barcode printer models of brands such as Toshiba, Avery Dennison. In addition, it is also used as coding foil on packaging in coding machines such as Videojet, Markem, Domino, Savema.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="nearEdge.png"},
                        new ProductImage(){ImagePath="nearedge2.jpg"},
                        new ProductImage(){ImagePath="nearedge3.png"}
                    }
                },
                 new SingleProductModel()
                {
                    ProductId=7,
                    ProductName="HOTFOİL RİBON",
                    Definition="  Used for printing the information on the product, such as production date, Best Before date, serial number, lot number, batch number, operating code, barcode, qr, logo, etc.",
                    Description="Hot coding foil used in manual coding machines. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="hotfoil1.jpg"},
                        new ProductImage(){ImagePath="hotfoil2.png"},
                        new ProductImage(){ImagePath="hotfoil3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=8,
                    ProductName=" COATED (GLOSSY) LABEL",
                    Definition=" On product, box, parcel, packaging and pallet.",
                    Description="One of the most preferred label types thanks to its self-sticking feature and strong adhesive. Printed with ribbon. One of the most used label types owing to its affordable price and strong adhesive. Coated labels can be used for printing virtually anything desired, easily and perfectly, thanks to its smooth surface.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="kuse1.png"},
                        new ProductImage(){ImagePath="kuse2.png"},
                        new ProductImage(){ImagePath="kuse3.png"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=9,
                    ProductName=" VELLUM LABEL",
                    Definition=" Pharmaceutical industry, product, box, parcel, pallet.",
                    Description="A paper based label. It has the same characteristics as the coated label. It is the surface that makes Vellum labels differ from the coated labels. Coated labels have smooth surfaces, while vellum labels have a rough surface. The print on vellum labels, which have a matt appearance, is read more easily by barcode readers.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="vellum1.jpg"},
                        new ProductImage(){ImagePath="vellum2.png"},
                        new ProductImage(){ImagePath="vellum3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=10,
                    ProductName=" THERMAL LABEL",
                    Definition=" Used particularly in businesses with a wide range of different products, e.g. stores, stationery, logistics, parcel and consumable products, etc.",
                    Description="During printing, the thermal part inside the barcode label printer becomes liquefied, eliminating the need for ribbons; therefore, thanks to the thermal labels, you can print on your labels without the use of ribbons.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="termal1.png"},
                        new ProductImage(){ImagePath="termal2.png"},
                        new ProductImage(){ImagePath="termal3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=11,
                    ProductName=" PP OPAQUE TAG",
                    Definition=" Largely used in chemical, cosmetic, food, furniture, glass industries.",
                    Description="A solid raw material for labels. It is included in the group of plastic based labels and does not decay or spoil due to the factors it might be exposed in outdoor environments to such as water, humidity and heat. Opaque Polypropylene, which is heat resistant, does not stretch or tear easily unless a force is applied.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="pp opak etiket.jpg"},
                        new ProductImage(){ImagePath="opak1.png"},
                        new ProductImage(){ImagePath="opak3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=12,
                    ProductName="SILVERMAT TAG",
                    Definition=" Usually used as inventory stock label, shelf/rack label, frame label in white goods s well as internal panel label in heating and cooking appliances as it is heat-resistant.",
                    Description="Silvermat labels, featuring a special adhesive, are made of plastic based materials resistant to cold and heat. Differently from other labels, both the printing surface and the adhesive surface are gray in color and are available in matte or glossy surfaces. Also called as store equipment (inventory stock) label. The printing and adhesive is long lasting. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="silvermat.jpg"},
                        new ProductImage(){ImagePath="silvermat2.jpg"},
                        new ProductImage(){ImagePath="silvermat3.png"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=13,
                    ProductName=" BRITTLE/DESTRUCTIBLE LABEL",
                    Definition=" Brittle labels are used in a number of areas such as inventory stock labels, electronic equipment labels, mobile phones, portable hard drives, etc.",
                    Description="Also knowns as tamper proof or warranty void label. The label produced from a special raw material leaves a mark when removed from the product, thanks to which the guarantee status is tracked in electronics and other products covered by a guarantee. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="kırılgan1.jpg"},
                        new ProductImage(){ImagePath="kırılgan2.jpg"},
                        new ProductImage(){ImagePath="kırılgan3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=14,
                    ProductName=" FASTYRE TAG",
                    Definition=" Generally used in textile, rubber/tyre industry and sacks.",
                    Description="Fastyre labels, a paper-based label type, have a special adhesive allowing quick adhesion onto rugged and rough surfaces. The adhesive part turns gray and the upper surface is coated with vellum or coated paper. Wax ribbons are used for printing by way of thermal transfer. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="fasty1.jpg"},
                        new ProductImage(){ImagePath="fasty2.jpg"},
                        new ProductImage(){ImagePath="fasty3.png"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=15,
                    ProductName=" FLUORESCENT TAG",
                    Definition=" Used in warehouses, archives, cargos, pharmaceuticals, etc. ",
                    Description="It has all the features of paper based labels. Fluorescent labels with vivid colors are more suitable and popular for indoor use and are preferred for that purpose. We are able to produce in 5 different color options.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="floresan1.jpg"},
                        new ProductImage(){ImagePath="floresan2.jpg"},
                        new ProductImage(){ImagePath="floresan3.jpg"}
                    }
                },
                     new SingleProductModel()
                {
                    ProductId=16,
                    ProductName=" FODDER AND SACK LABEL",
                    Definition=" Used on fodder, flour, legumes, fertilizer, coal, yarn sacks, etc.",
                    Description="Produced without any adhesive, these labels are sewn on the sack before use.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="yemvecuval.jpg"},
                        
                        new ProductImage(){ImagePath="yemcuval.jpg"}
                    }
                },
                     new SingleProductModel()
                {
                    ProductId=17,
                    ProductName="JEWELLERY AND OPTICS LABEL",
                    Definition=" Used in spectacle/eyeglasses frames and lenses and in the promotion and classification of jewellery.",
                    Description="It is a kind of label produced in sizes appropriate for jewellers and opticians. We can produce all sizes you need (tailor made production available).",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="kuyumcu1.png"},
                        new ProductImage(){ImagePath="kuyumcu2.jpg"},
                        new ProductImage(){ImagePath="kuyumcu3.jpg"}
                    }
                }

            };
            singleProductModelsTr = new List<SingleProductModel>()
            {
                new SingleProductModel()
                {
                    ProductId=1,
                    ProductName="WAX RİBON",
                    Description="Wax ribon tüm barkod yazıcılara uyumludur. Birçok ürün etiketlerinde kullanılabilmektedir. Uzun ömürlü baskı kalıcılığı ve uygun fiyatlı olduğu için tercih sebebi olmaktadır. Wax ribon ile kuşe, vellum, kırılgan etiket gibi tüm kâğıt bazlı etiketlere baskı alınabilmektedir.",
                    Definition=" Genelde kâğıt bazlı kuşe etiket ve vellum etiketlerde wax ribon tercih sebebidir.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="wax2.jpg"},
                        new ProductImage(){ImagePath="waxRibon.jpg"},
                        new ProductImage(){ImagePath="wax3.jpg"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=2,
                    ProductName=" WAX-RESİN RİBON",
                    Definition="  Polietilen, Polipropilen, Data PE kağıtlara baskı amaçlı kullanılır.",
                    Description="Wax ribonlara göre daha dayanıklı, lekelere dirençli, yüksek çözünürlükteki barkod yazıcılar için ideal termal transfer ribon türüdür. Sürtünmeye ve dış etkenlere karşı yüksek dayanıklılık sağlayan wax-resin ribon ile kâğıt bazlı ve sentetik üzerine baskı alınabilmektedir. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="waxResin3.jpg"},
                        new ProductImage(){ImagePath="waxResin2.jpg"},
                        new ProductImage(){ImagePath="WaxResin1.jpg"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=3,
                    ProductName="RESİN RİBON",
                    Definition=" Silvermat, Whitemat, Glosswhite, Care Label (Japon Akmaz) kâğıt ve bez etiketlere baskı amaçlı kullanılır.",
                    Description="Genel amaçlı yüksek yoğunluklu, ısıya, silinmeye ve aşınmaya dayanıklı, statiklenme yapmayan kalıcı olması zorunlu tüm baskı uygulamaları için ideal termal transfer ribondur. Tekstil baskılarında en ağır yıkamalara dayanıklı olan resin ribon alkol testinde de çıkmamaktadır. Resin ribonla polyester, polimid, polipropilen ve polietilen etiketlere baskı yapmak mümkündür.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="resin2.png"},
                        new ProductImage(){ImagePath="resin ribon.png"},
                        new ProductImage(){ImagePath="resin3.png"}
                    }
                },
                new SingleProductModel()
                {
                    ProductId=4,
                    ProductName=" RENKLİ RİBON",
                    Definition=" Wax, wax resin ve resin ribonun kullanıldığı her yerde uygulanabilir.",
                    Description="Tüm ribonlar ile aynı özelliği taşımakta olup tek farklı özellikleri renkli oluşlarıdır. Vellum, kuşe ve silvermat etiket, PP, PE gibi birçok yüzeye güvenle uygulanabilmektedir.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="rrenkliribon.jpg"},
                        new ProductImage(){ImagePath="renkliribon2.jpg"},
                       
                    }
                },
                new SingleProductModel()
                {
                    ProductId=5,
                    ProductName=" TARİH KODLAMA / HOTFOİL RİBON",
                    Definition=" Üretim tarihi, son kullanma tarihi, seri numarası, lot numarası, parti numarası, işletme kodu, barkod, karekod, logo vb. bilgilerin ürün üzerine yazılma işlemlerinde kullanılır.",
                    Description=" Genellikle ambalaj üzerine tarih ve lot numarası baskıları için kullanılır. Plastik bazlı ambalajlarda yüksek tutunma sağlayan tarih kodlama folyosu birçok renkte satılmaktadır. En fazla kullanılan siyah ve beyaz renklerdir.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="tarihkodlama.jpg"},
                        new ProductImage(){ImagePath="hotfoil2.jpg"},
                        new ProductImage(){ImagePath="hotfoil3.jpg"}
                    }
                },
                 new SingleProductModel()
                {
                    ProductId=6,
                    ProductName="NEAR EDGE RİBON",
                    Definition=" Vellum, kuşe kâğıt ve bazı sentetikler, parlak kağıtlar gibi pek çok çeşit materyal üzerinde Near Edge yazıcılarda baskı sağlar.  ",
                    Description="Near edge ribon ile yüksek hızlarda baskı alınabilmektedir. Yüksek dayanıklılığı sayesinde birçok uygulamada kullanılmaktadır. Kullanım alanları resin ribonlar kadar geniş değildir. Toshiba, Avery Dennison gibi markaların bazı barkod yazıcı modellerinde kullanılmaktadır. Bunun yanında Videojet, Markem, Domino, Savema gibi kodlama makinalarında ambalaj üzeri tarih kodlama folyosu olarakta kullanılmaktadır.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="nearEdge.png"},
                        new ProductImage(){ImagePath="nearedge2.jpg"},
                        new ProductImage(){ImagePath="nearedge3.png"}
                    }
                },
                 new SingleProductModel()
                {
                    ProductId=7,
                    ProductName="HOTFOİL RİBON",
                    Definition=" Üretim tarihi, son kullanma tarihi, seri numarası, lot numarası, parti numarası, işletme kodu, barkod, karekod, logo vb. bilgilerin ürün üzerine yazılma işlemlerinde kullanılır.",
                    Description="Manuel kodlama makinalarında kullanılan sıcak kodlama folyosudur. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="hotfoil1.jpg"},
                        new ProductImage(){ImagePath="hotfoil2.png"},
                        new ProductImage(){ImagePath="hotfoil3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=8,
                    ProductName=" KUŞE ETİKET",
                    Definition=" Ürün, paket, koli, ambalaj ve palet üzeri ",
                    Description="Kendinden yapışkanlı ve kuvvetli yapışkanı ile en çok tercih edilen etiket çeşitlerindendir. Ribon ile baskı alınmaktadır. Uygun fiyatlı ve kuvvetli yapışkanı ile en çok kullanılan etiket çeşitlerinden bir tanesidir. Kuşe etiketlere, pürüzsüz yüzeyi sayesinde kolay ve kusursuz bir şekilde istenilen baskılar alınabilmektedir.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="kuse1.png"},
                        new ProductImage(){ImagePath="kuse2.png"},
                        new ProductImage(){ImagePath="kuse3.png"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=9,
                    ProductName=" VELLUM ETİKET",
                    Definition=" İlaç sektörü, ürün, paket, koli, palet üzeri",
                    Description="Kâğıt bazlı bir etiket çeşididir. Kuşe etiket ile aynı özelliklere sahiptir. Vellum etiketleri kuşe etiketlerden ayıran fark yüzeyidir. Kuşe etiketlerin yüzeyleri pürüzsüz iken vellum etiketler pütürlü yüzeye sahiptir. Mat bir görünüme sahip olan vellum etiketlerin baskısı barkod okuyuculara daha net bir şekilde okunmaktadır.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="vellum2.png"},
                        new ProductImage(){ImagePath="vellum.png"},
                        new ProductImage(){ImagePath="vellum3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=10,
                    ProductName=" TERMAL ETİKET",
                    Definition=" Özellikle mağaza, kırtasiye, lojistik, koli ve sarf ürün çeşitliliği fazla olan işletmelerde kullanılmaktadır.",
                    Description="Baskı sırasında barkod etiket yazıcısının içerisindeki ısı ile termal kısım sıvılaşma özelliği gösterir ve ribon ihtiyacını ortadan kaldırır. Bu sayede termal etiketlerle ribon kullanımına gerek kalmadan etiketlerinize baskı alabilirsiniz.",
                    ProductImages=new List<ProductImage>()
                    {
                         new ProductImage(){ImagePath="termal1.png"},
                        new ProductImage(){ImagePath="termal2.png"},
                        new ProductImage(){ImagePath="termal3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=11,
                    ProductName=" PP OPAK ETİKET",
                    Definition=" Kimya, kozmetik, gıda, mobilya, cam endüstrilerinde oldukça fazla kullanımı vardır.",
                    Description=" Sert yapıdan oluşan bir etiket hammaddesidir. Plastik bazlı etiketler grubundadır ve suda, nem, ısı gibi dış ortamlarda maruz kalabileceği etkenlerde bozulma özelliği göstermez. Isıya ışığa dayanıklı olan Opak Polipropilen, esnemez ve zorlanmadığı müddetçe kolay kolay yırtılmaz.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="pp opak etiket.jpg"},
                        new ProductImage(){ImagePath="opak1.png"},
                        new ProductImage(){ImagePath="opak3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=12,
                    ProductName="SİLVERMAT ETİKET",
                    Definition=" Genel olarak demirbaş etiketi, raf etiketleri, beyaz eşya sektöründe gövde etiketi,ısıtıcı ve pişirici ürünlerde ısıya dayanıklı olduğundan iç panel etiketi olarak kullanılırlar.",
                    Description="Özel bir yapışkana sahip olan silvermat etiketler soğuk ve sıcak etkenlere karşı dayanıklı plastik bazlı malzemelerden üretilmektedir. Diğer etiketlerden farklı olarak hem baskı yüzeyi hem de yapışkanlı yüzeyi gri renkte olup, mat veya parlak olmak üzere seçenekleri bulunmaktadır. Demirbaş etiketi olarakta adlandırılmaktadır. Baskı ve yapışkanlığı uzun ömürlüdür.   ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="silvermat.jpg"},
                        new ProductImage(){ImagePath="silvermat2.jpg"},
                        new ProductImage(){ImagePath="silvermat3.png"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=13,
                    ProductName=" KIRILGAN ETİKET",
                    Definition=" Kırılgan etiketler demirbaş etiketi, elektronik cihaz etiketleri, cep telefonları, taşınabilir hard diskler gibi birçok alanda kullanılan etiketlerdir.",
                    Description="Kırılgan etiket bir güvenlik etiket çeşididir. Garanti etiketi adlandırılmaktadır. Özel bir hammaddeden üretilen etiket yapışkanı sayesinde üzerine yapıştırıldığı üründen çıkarılmak istendiğinde iz bırakarak sökülmektedir. Bu sayede elektronik ve garantili üzdürenlerde, garanti durumunun takibini yapmak amacıyla kullanılmaktadır.  ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="kırılgan1.jpg"},
                        new ProductImage(){ImagePath="kırılgan2.jpg"},
                        new ProductImage(){ImagePath="kırılgan3.jpg"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=14,
                    ProductName=" FASTYRE ETİKET",
                    Definition=" Genellikle tekstil, lastik sektörü ve çuval üzerinde kullanılmaktadır.",
                    Description="Kâğıt bazlı bir etiket çeşidi olan fastyre etiketler, özel bir yapışkana sahip olduğu için bozuk ve pürüzlü yüzeylere kolay bir şekilde yapışma özelliğine sahiptir. Yapışkanlı kısmı gri bir renk almaktadır, üst yüzeyi vellum ya da kuşe kâğıt ile kaplanmıştır. Wax ribon ile termal transfer yöntemi ile baskı alınmaktadır. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="fasty1.jpg"},
                        new ProductImage(){ImagePath="fasty2.jpg"},
                        new ProductImage(){ImagePath="fasty3.png"}
                    }
                },
                    new SingleProductModel()
                {
                    ProductId=15,
                    ProductName=" FLORESAN ETİKET",
                    Definition=" Depolar, arşivler, kargolar, ilaç sektörü gibi alanlarda kullanılmaktadır. ",
                    Description="Kâğıt bazlı etiketlerin tüm özelliklerine sahiptir. Canlı renklere sahip olan floresan etiketler iç mekân kullanımlarına daha uygundur ve bu yönde tercih edilmektedir. 5 farklı renk seçeneği ile üretimini yapabilmekteyiz. ",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="floresan1.jpg"},
                        new ProductImage(){ImagePath="floresan2.jpg"},
                        new ProductImage(){ImagePath="floresan3.jpg"}
                    }
                },
                     new SingleProductModel()
                {
                    ProductId=16,
                    ProductName=" YEM VE ÇUVAL ETİKETİ",
                    Definition="Yem, un, bakliyat, gübre, kömür, iplik çuvalları üzerinde kullanılabilir.",
                    Description="Yapışkansız olarak üretilen bu etiketler, çuval üzerine dikilerek kullanılmaktadır. ",
                    ProductImages=new List<ProductImage>()
                    {
                         new ProductImage(){ImagePath="yemvecuval.jpg"},
                       
                        new ProductImage(){ImagePath="yemcuval.jpg"}
                    }
                },
                     new SingleProductModel()
                {
                    ProductId=17,
                    ProductName="KUYUMCU VE OPTİK ETİKETİ",
                    Definition="Gözlük çerçeveleri ve gözlük camlarında, takıların tanıtımı ve tasnifinde kullanılır.",
                    Description="Kuyumcular ve gözlükçüler için uygun boyutlarda üretilen etiket çeşididir. İhtiyacınız olan tüm ölçülerde üretim yapabilmekteyiz.",
                    ProductImages=new List<ProductImage>()
                    {
                        new ProductImage(){ImagePath="kuyumcu1.png"},
                        new ProductImage(){ImagePath="kuyumcu2.jpg"},
                        new ProductImage(){ImagePath="kuyumcu3.jpg"}
                    }
                }

            };
        }
        public List<SingleProductModel> singleProductModels { get; set; }
        public List<SingleProductModel> singleProductModelsTr { get; set; }
    }
}