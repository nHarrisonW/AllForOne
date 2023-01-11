using Microsoft.AspNetCore.Mvc;
using StudentDirectoryApi.Models;
namespace AllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge8Controller : ControllerBase
{
    public List<StudentListModel> studentsList = new List<StudentListModel>()
      {
          
         new StudentListModel(){
            firstName = "Danny",
            lastName = "Tran",
            slackName = "Danny Tran",
            email = "dannytran@gmail.com",
            hobbies = "Being an awesome TA"
         },
         new StudentListModel(){
            firstName = "Scott",
            lastName = "Morenzone",
            slackName = "Scott Morenzone",
            email = "scottmorenone@gmail.com",
            hobbies = "Just being the best TA"
         },
         new StudentListModel(){
            firstName = "Ken",
            lastName = "Martinez",
            slackName = "Ken Martinez",
            email = "kenmartinez@gmail.com",
            hobbies = "Being the best Boss ever!!!!"
         },
         new StudentListModel(){
            firstName = "Aisha",
            lastName = "Mashrah",
            slackName = "Aisha Mashrah",
            email = "amashrah@codestack.co",
            hobbies = "Painting"
         },
         new StudentListModel(){
            firstName = "Amar",
            lastName = "Mann",
            slackName = "Amar",
            email = "amann@codestack.co",
            hobbies = "Kicking Rocks"
         },
         new StudentListModel(){
            firstName = "Andrea",
            lastName = "Burr",
            slackName = "Andrea Burr",
            email = "aburr@codestack.co",
            hobbies = "Horse Riding"
         },
         new StudentListModel(){
            firstName = "Andrew",
            lastName = "Nilsson",
            slackName = "Drew Nilsson",
            email = "anilsson@codestack.co",
            hobbies = "Playing Video Games"
         },
         new StudentListModel(){
            firstName = "Carlos",
            lastName = "Felipe",
            slackName = "Carlos",
            email = "cfelipe@codestack.co",
            hobbies = "Singing in the Car, Watching YouTube Videos, Anime"
         },
         new StudentListModel(){
            firstName = "Caroline",
            lastName = "Hana",
            slackName = "Caroline Hana",
            email = "chana@codestack.co",
            hobbies = "Play Games, Anime, Hanging Out With Friends"
         },
         new StudentListModel(){
            firstName = "Chris",
            lastName = "Martinez",
            slackName = "Chris Martinez",
            email = "cmartinez@codestack.co",
            hobbies = "Playing Ping Pong"
         },
         new StudentListModel(){
            firstName = "Brandon",
            lastName = "Le",
            slackName = "Brandon Le",
            email = "ble@codestack.co",
            hobbies = "Sleeping, Eating"
         },
         new StudentListModel(){
            firstName = "Daniel",
            lastName = "Decoito",
            slackName = "Daniel Decoito",
            email = "danieldecoito@gmali.com",
            hobbies = "Bears, Beets, Battlestar Galactica"
         },
         new StudentListModel(){
            firstName = "Elizar",
            lastName = "Garcia",
            slackName = "Elizar Garcia",
            email = "egarcia@codestack.co",
            hobbies = "Bowling and Sleeping"
         },
         new StudentListModel(){
            firstName = "Fernando",
            lastName = "Aguilar",
            slackName = "Freddy Aguilar",
            email = "faguilar@codestack.co",
            hobbies = "Video Games, Reading, Writing"
         },
         new StudentListModel(){
            firstName = "Griffin",
            lastName = "Parker",
            slackName = "Griffin Parker",
            email = "gparker@codestack.co",
            hobbies = "Singing, Reading, Video Games"
         },
         new StudentListModel(){
            firstName = "Harrison",
            lastName = "Busby",
            slackName = "Harrison Busby",
            email = "hbusby@codestack.co",
            hobbies = "Piano"
         },
         new StudentListModel(){
            firstName = "Isaiah",
            lastName = "Ferguson",
            slackName = "Isaiah Ferguson",
            email = "iferguson@codestack.co",
            hobbies = "Martial Arts, Tricking, Hiking, Watching slice of life anime"
         },
         new StudentListModel(){
            firstName = "Jacob",
            lastName = "Dekok",
            slackName = "Jacob Dekok",
            email = "jdekok@codestack.co",
            hobbies = "Copying Jeremy, Body Building, Powerlifting, Wrestling"
         },
         new StudentListModel(){
            firstName = "Jeremy",
            lastName = "Lapham",
            slackName = "Muscle Baby",
            email = "jlapham@codestack.co",
            hobbies = "Body Building, Powerlifting, Wrestling"
         },
         new StudentListModel(){
            firstName = "Jessie",
            lastName = "Lamzon",
            slackName = "Jessie Lamzon",
            email = "jlamzon@codestack.co",
            hobbies = "Fix Electronics, Video Editing, Cooking, Traveling"
         },
         new StudentListModel(){
            firstName = "John",
            lastName = "Magpantay",
            slackName = "John Magpantay",
            email = "jmagpantay@codestack.co",
            hobbies = "FPS Video Games"
         },
         new StudentListModel(){
            firstName = "Jovann",
            lastName = "Contreras",
            slackName = "Jovann Contreras",
            email = "jcontreras@codestack.co",
            hobbies = "Collecting Comics & Vintage Items"
         },
         new StudentListModel(){
            firstName = "Kenneth",
            lastName = "Fujimura",
            slackName = "Kenneth Fujimura",
            email = "kfujimura@codestack.co",
            hobbies = "Games, Sports, Model Kits, Anime, Naps, Culinary Tourism"
         },
         new StudentListModel(){
            firstName = "Kent",
            lastName = "Tupas",
            slackName = "Kent Tupas",
            email = "ktupas@codestack.co",
            hobbies = "Weeb"
         },
         new StudentListModel(){
            firstName = "Lerissa",
            lastName = "Lazar",
            slackName = "Lerissa Lazar",
            email = "llazar@codestack.co",
            hobbies = "Drawing, Anime"
         },
         new StudentListModel(){
            firstName = "Madeline",
            lastName = "Gowan",
            slackName = "Maddie Gowan",
            email = "mgowan@codestack.co",
            hobbies = "Drawing, Rodents, Drawing Rodents"
         },
         new StudentListModel(){
            firstName = "Manuel",
            lastName = "Leyva",
            slackName = "Manuel Leyva",
            email = "mleyva@codestack.co",
            hobbies = "Soccer, Baseball, Football, Photography"
         },
         new StudentListModel(){
            firstName = "Marcel",
            lastName = "Rodriguez",
            slackName = "Marcel Rodriguez",
            email = "mrodriguez@codestack.co",
            hobbies = "Card Games"
         },
         new StudentListModel(){
            firstName = "Mark",
            lastName = "Ramirez",
            slackName = "Mark Ramirez",
            email = "mramirez@codestack.co",
            hobbies = "Video Games, Hydration"
         },
         new StudentListModel(){
            firstName = "N. Harrison",
            lastName = "Wilkins",
            slackName = "Harrison Wilkins",
            email = "nwilkins@codestack.co",
            hobbies = "Motorsport, Video Games, Skateboarding"
         },
         new StudentListModel(){
            firstName = "Pedro",
            lastName = "Castaneda",
            slackName = "Pedro Castaneda",
            email = "pcastaneda@codestack.co",
            hobbies = "Archery, Skateboarding, Camping, Hiking, Traveling"
         },
         new StudentListModel(){
            firstName = "Rafael",
            lastName = "Manzo",
            slackName = "Rafael Manzo",
            email = "prormanzo@gmail.com",
            hobbies = "Dogs, Video Games, Finance, Business, Films, Hiking"
         },
         new StudentListModel(){
            firstName = "Reed",
            lastName = "Goodwin",
            slackName = "Reed Goodwin",
            email = "rgoodwin@codestack.co",
            hobbies = "Skateboarding, Video Games"
         },
         new StudentListModel(){
            firstName = "Richard",
            lastName = "Johnson",
            slackName = "Richard Johnson",
            email = "rjohnson@codestack.co",
            hobbies = "Drawing, Video Games, YouTube"
         },
         new StudentListModel(){
            firstName = "Samuel",
            lastName = "Laguna",
            slackName = "Samuel Laguna",
            email = "slaguna@codestack.co",
            hobbies = "Football, Video Games"
         },
         new StudentListModel(){
            firstName = "Shaun",
            lastName = "Aguirre-Reyes",
            slackName = "Shaun Aguirre-Reyes",
            email = "saguirre-reyes@codestack.co",
            hobbies = "Writing, Gaming, Camping, Music"
         },
         new StudentListModel(){
            firstName = "Ulises",
            lastName = "Ortega",
            slackName = "Ulises Ortega",
            email = "uortega@codestack.co",
            hobbies = "Gaming, Rollerblading, Skimboarding, Board Games"
         }
      };

    

    [HttpGet]
    [Route("GetStudentByFirstName/{studentFirstName}")]
    public StudentListModel GetStudentByFirstName(string studentFirstName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            if (studentsList[i].firstName == studentFirstName)
            {
                result = studentsList[i];
                break;
            }
        }
        return result;

    }
    
    [HttpGet]
    [Route("GetStudentByLastName/{studentLastName}")]
    public StudentListModel GetStudentByLastName(string studentLastName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            if (studentsList[i].lastName == studentLastName)
            {
                result = studentsList[i];
                break;
            }
        }
        return result;
    }

    [HttpGet]
    [Route("GetStudentBySlackName/{studentSlackName}")]
    public StudentListModel GetStudentBySlackName(string studentSlackName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            if (studentsList[i].slackName == studentSlackName)
            {
                result = studentsList[i];
                break;
            }
        }
        return result;
    }

    [HttpGet]
    [Route("GetStudentByEmail/{studentEmail}")]
    public StudentListModel GetStudentByEmail(string studentEmail)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            if (studentsList[i].email == studentEmail)
            {
                result = studentsList[i];
                break;
            }
        }
        return result;
    }
}