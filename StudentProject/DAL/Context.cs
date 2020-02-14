namespace DAL
{
    public class Context
    {
        protected StudentContext context;
        public Context()
        {
            context = new StudentContext();
        }
    }
}
