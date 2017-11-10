using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDAL.GraphicsProcess;

namespace ClassLibraryBLL.CreatePageBLL
{
    public enum ButtonSellection
    {
        FiveMasterImages,
        LandingPageForSizeChart,
        LandingPageForMaterialAndPattern,
        LandingPageForModelShow01,
        LandingPageForModelShow02,
        LandingPageForModelShow03,
        LandingPageForModelShow04,
        LandingPageForModelShow05,
        LandingPageForModelShow06
    }
    public class CreateLandingPagesBLL
    {
        GraphicsOS graphicsOS;
        /// <summary>
        /// S码被选中
        /// </summary>
        private CreateLandingPagesBLL()
        {
            graphicsOS = new GraphicsOS();
        }
        public string SmallSize { get; set; }
        /// <summary>
        /// 衣服S码衣长
        /// </summary>
        public double SmallSizeClothesLength { get; set; }
        /// <summary>
        /// 衣服S码袖长
        /// </summary>
        public double SmallSizeSleevesLength { get; set; }
        /// <summary>
        /// 衣服S码胸围(女性)
        /// </summary>
        public double SmallSizeBustWidth { get; set; }
        /// <summary>
        /// 衣服S码肩宽
        /// </summary>
        public double SmallSizeShoulderAcross { get; set; }
        public void ClickedButtonStatus(ButtonSellection buttonSellection)
        {
            switch (buttonSellection)
            {
                case ButtonSellection.FiveMasterImages:
                    break;
                case ButtonSellection.LandingPageForSizeChart:
                    break;
                case ButtonSellection.LandingPageForMaterialAndPattern:
                    break;
                case ButtonSellection.LandingPageForModelShow01:
                    break;
                case ButtonSellection.LandingPageForModelShow02:
                    break;
                case ButtonSellection.LandingPageForModelShow03:
                    break;
                case ButtonSellection.LandingPageForModelShow04:
                    break;
                case ButtonSellection.LandingPageForModelShow05:
                    break;
                case ButtonSellection.LandingPageForModelShow06:
                    break;
            }
        }
        public void UseDrawTable()
        {

        }
    }
}
