class Excep
    {


        public void CheckUserName(string user)
        {
            try
            {
                
                if (user[0] > 90)
                {
                    throw new ApplicationException("First letter should be in upper case");
                }
                

            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex);

            }
            finally
            {
                Console.WriteLine("Thanks for the details");
                
            }
         
        }
       
        public void CheckPhoneNumber(string phone)
        {
            try
            {
                Regex reg = new Regex(@"^[0-9]{10}$");
                if (!reg.IsMatch(phone)) 
                {
                    throw new ApplicationException("Please enter valid phone Number");
                }
            }
            catch (ApplicationException ex)
            {

                Console.WriteLine(ex);
            }
        }

        public void CheckAddress(string address)
        {
              try
                {
                
                    if (30 > address.Length)
                    {
                        throw new ApplicationException("Please enter address more than 30 char");
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex);
                }
                
            
        }
       
    }


    class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            string Address;
            string PhoneNo;
            
            Console.WriteLine("Enter the UserName:");
            UserName = Console.ReadLine();

            Console.WriteLine("Enter the Phone Number:");
            PhoneNo = Console.ReadLine();

            Console.WriteLine("Enter the Address:");
            Address = Console.ReadLine();

            Excep ex = new Excep();

            ex.CheckUserName(UserName);
            ex.CheckPhoneNumber(PhoneNo);

            Console.ReadKey();
        }
    }