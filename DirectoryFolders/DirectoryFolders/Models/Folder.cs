using System.ComponentModel.DataAnnotations;

namespace DirectoryFolders.Models
{
    public class Folder
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ParentFolderID { get; set; }
        public List<Folder> ChildFolders { get; set; }
    }
}
