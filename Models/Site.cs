using System.ComponentModel.DataAnnotations;

public class Site
{
    public int Id { get; set; }

    [Required]
    public string Ort { get; set; }

    [Required]
    public string Gatuadress { get; set; }

    [Required]
    public string SiteTyp { get; set; }

    public string GammalAdress { get; set; }

    [Required]
    public string Leverantör { get; set; }

    [Required]
    public string Status { get; set; }

    [Required]
    public string Nätverkskapacitet { get; set; }

    public string KontaktNamn { get; set; }

    public string ISSKontorSite { get; set; }

    public string Mobilnr { get; set; }

    public string Epostadress { get; set; }

    [Required]
    public string WANUplink { get; set; }

    public int AntalEnheter { get; set; }

    public string SiteStorlek { get; set; }

    public string Kommentarer { get; set; }
}
