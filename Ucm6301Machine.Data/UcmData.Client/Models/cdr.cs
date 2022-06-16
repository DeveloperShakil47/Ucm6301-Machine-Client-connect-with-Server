using System.ComponentModel.DataAnnotations;

namespace UcmData.Client.Models
{
    public class cdr
    {
        [Key]
        public int AcctId { get; set; }
        public string  accountcode { get; set; }
        public string src { get; set; }
        public string  dst { get; set; }
        public string clid { get; set; }
        public DateTime start { get; set; }
        public DateTime answer { get; set; }
        public DateTime end { get; set; }
        public int duration { get; set; }
        public int billsec { get; set; }
        public string dstchannel_ext { get; set; }
        public string src_trunk_name { get; set; }
    }
}