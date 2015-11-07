using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleBarsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTest();
            Console.Write("\nDone. Press any key to end...");
            Console.ReadKey();
        }

        private static void DoTest()
        {
            string source =
                @"<div>
                    {{#each this}}
                        <div class='row'>
                            <div class='col-md-12'>
                                <h4>{{Name}}</h4>
                                {{JobCode}}
                            </div>
                        </div>        
                    {{else}}
                        <p>No data available</p>
                    {{/each}}        
                </div>";

            var template = Handlebars.Compile(source);
            

            var json = @"[
                {
                    'Name': 'My Name',
                    'JobCode': 'My Job Code'
                },
                {
                    'Name': 'My Name2',
                    'JobCode': 'My Job Code2'
                }
            ]";

            var result = template(json);

            Console.WriteLine(result);

        }
    }
}
