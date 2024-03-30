namespace Model
{
    public class SchoolDetails
    {
        public string? Url { get; set; }
        public string? JoiningDate { get; set; }
        public string? Gender { get; set; }
        public string? Name { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PinCode { get; set; }
        public string? LandMark { get; set; }
        public string? AdditionalAddress { get; set; }
        public string? Address { get; set; }
        public List<Assosication>? Associations { get; set; }
        public List<Management>? Management { get; set; }
        public List<Facility>? Facilities { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Level>? Level { get; set; }
        public List<Categories>? Categories { get; set; }
        public List<Ownership>? Ownership { get; set; }
        public List<Governance>? Governance { get; set; }
        public string? YearOfEst { get; set; }
        public string? InstitutionName { get; set; }
        public string? InstitutionId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailId { get; set; }
        public string? AffiliationID { get; set; }

    }
}