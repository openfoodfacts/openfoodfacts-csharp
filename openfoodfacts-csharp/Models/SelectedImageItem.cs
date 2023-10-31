namespace OpenFoodFactsCSharp.Models
{
    public class SelectedImageItem
    {
        public string En { get; set; }
        
        public string Fr { get; set; }
        
        public string Pl { get; set; }
        
        public string GetUrl()
        {
            return En ?? Fr ?? Pl;
        }
    }
}
