namespace Abstract_demo{
 

 
    internal class Customer{
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long Contact { get; set; }
 
        public Date DOB {get;set;}
 
      
 
        public Customer(int customerid, string fname, string lname, string email, string address, long contact, Date dob){
            CustomerId = customerid;
            FirstName = fname;
            LastName = lname;
            Email = email;
            Address = address;
            Contact = contact;
            DOB = dob;
 
        }
 
        public override string ToString(){
            return $"Customer Details: {CustomerId} {FirstName} {LastName} {Email} {Address} {Contact} {DOB}";
        }
    }
}