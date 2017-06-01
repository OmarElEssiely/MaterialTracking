namespace Domain
{
    public class ProjectFile
    {
        public int ProjectFileId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Project Project { get; set; }
        public ProjectSubFolder ProjectSubFolder { get; set; }
    }
}
