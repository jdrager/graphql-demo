using GraphQL.Types;

namespace graphql_demo
{
    public class HelloWorldSchema : Schema
    {
        public HelloWorldSchema(HelloWorldQuery query)
        {
            Query = query;
        }
    }
}