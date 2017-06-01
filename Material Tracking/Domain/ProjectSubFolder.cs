namespace Domain
{
    public class ProjectSubFolder
    {
        public int ProjectSubFolderId { get; set; }
        public string Name { get; set; }
        public ProjectFolder ProjectFolder { get; set; }
    }
}
