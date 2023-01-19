//using C44444;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace C44444
{
    public class Program
    {
        //static void Display(User u)
        //{
        //    Console.WriteLine(u);
        //}
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine(@"1)USER 
2)ADMIN ");


                Console.WriteLine("Select your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                List<User> users = new List<User>
            {
                new User
                {
                    Id=1,
                    Name="Elchin",
                    Surname="Guliyev",
                    Age="20",
                    Email="elchingulievv@gmail.com",
                    Password="elcin123"
                },
                new User
                {
                    Id=2,
                    Name="Ayshan",
                    Surname="Orujlu",
                    Age="20",
                    Email="ayshan123@gmail.com",
                    Password="ayshan123"
                },
                new User
                {
                    Id=3,
                    Name="Islam",
                    Surname="Salamzade",
                    Age="20",
                    Email="islam123@gmail.com",
                    Password="islam123"
                },
                      new User
                {
                    Id=4,
                    Name="Rustam",
                    Surname="Mammadov",
                    Age="31",
                    Email="rustam123@gmail.com",
                    Password="rustam123"
                },
                            new User
                {
                    Id=5,
                    Name="Namiq",
                    Surname="Rasullu",
                    Age="27",
                    Email="namiq123@gmail.com",
                    Password="nami123"
                }
            };

                if (choice==1)
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        Console.WriteLine(users[i]+"\n");
                    }
                    string? us = "";
                    Console.WriteLine("Enter username : ");
                    us = Console.ReadLine();
                    string? ps = "";
                    Console.WriteLine("Enter password : ");
                    ps = Console.ReadLine();
                    Console.Clear();
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (us == users[i].Name && ps == users[i].Password)
                        {
                            Console.WriteLine("Successufully access");
                          
                        }
                    }


                    List<Post> posts = new List<Post>
                        {
                            new Post
                            {
                                Id=1,
                                LikeCount=0,
                                ViewCount=0,
                            },
                            new Post
                            {
                                Id=2,
                                LikeCount=0,
                                ViewCount=0,
                            },
                            new Post
                            {
                                Id=3,
                                LikeCount=0,
                                ViewCount=0,
                            },


                        };

                    for (int i = 0; i < posts.Count; i++)
                        {
                            Console.WriteLine(posts[i]+"");
                            Console.WriteLine("ID : "+posts[i].Id+" created");
                            //Post.CreationDateTime();

                        }

                  
                        Console.WriteLine("Select your post choice 1/2/3 : ");
                        int choicePost = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (choicePost==posts[0].Id)
                        {
                            Console.WriteLine(posts[0]);
                            Console.WriteLine("Select your choice 1.Like / 2.View: ");
                            int choiceLikeOrView = Convert.ToInt32(Console.ReadLine());
                            if (choiceLikeOrView==1)
                            {
                                posts[0].LikeCount++;
                                Console.WriteLine(posts[0].LikeCount);
                            }
                            else if (choiceLikeOrView==2)
                            {
                                posts[0].ViewCount++;
                                Console.WriteLine(posts[0].ViewCount);
                            }
                            for (int i = 0; i < posts.Count; i++)
                            {
                                Console.WriteLine("Id : "+posts[i].Id+"\n"+"Post like count :"+posts[i].LikeCount+"\n"+"Post view count : "+posts[i].ViewCount);
                            }

                        }

                        else if (choicePost==posts[1].Id)
                        {
                            Console.WriteLine(posts[1]);
                            Console.WriteLine("Select your choice 1.Like / 2.View: ");
                            int choiceLikeOrView = Convert.ToInt32(Console.ReadLine());
                            if (choiceLikeOrView==1)
                            {
                                posts[1].LikeCount++;
                                Console.WriteLine(posts[1].LikeCount);
                            }
                            else if (choiceLikeOrView==2)
                            {
                                posts[1].ViewCount++;
                                Console.WriteLine(posts[1].ViewCount);
                            }
                            for (int i = 0; i < posts.Count; i++)
                            {
                                Console.WriteLine("Id : "+posts[i].Id+"\n"+"Post like count :"+posts[i].LikeCount+"\n"+"Post view count : "+posts[i].ViewCount);
                            }
                        }
                        else if (choicePost==posts[2].Id)
                        {
                            Console.WriteLine(posts[2]);
                            Console.WriteLine("Select your choice 1.Like / 2.View: ");
                            int choiceLikeOrView = Convert.ToInt32(Console.ReadLine());
                            if (choiceLikeOrView==1)
                            {
                                posts[2].LikeCount++;
                                Console.WriteLine(posts[2].LikeCount);
                            }
                            else if (choiceLikeOrView==2)
                            {
                                posts[2].ViewCount++;
                                Console.WriteLine(posts[2].ViewCount);
                            }
                            for (int i = 0; i < posts.Count; i++)
                            {
                                Console.WriteLine("Id : "+posts[i].Id+"\n"+"Post like count :"+posts[i].LikeCount+"\n"+"Post view count : "+posts[i].ViewCount);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong selection !!! Go back and try again!!!");

                        }


                    
                }
                else if (choice==2)
                {

                    List<Admin> admins = new List<Admin>
                        {
                            new Admin
                            {
                                Id=1,
                                NameAdmin="Admin 1",
                                EmailAdmin="admin1@gmail.com",
                                PasswordAdmin="admin1"
                            },
                            new Admin
                            {
                                Id=2,
                                 NameAdmin="Admin 2",
                                EmailAdmin="admi2n2@gmail.com",
                                PasswordAdmin="admin2"
                            },
                            new Admin
                            {
                                Id=3,
                                  NameAdmin="Admin 3",
                                EmailAdmin="admin3@gmail.com",
                                PasswordAdmin="admin3"
                            },


                        };
                    for (int i = 0; i < admins.Count; i++)
                    {
                        Console.WriteLine(admins[i]+"\n");
                    }
                    string? usad = "";
                    Console.WriteLine("Enter username : ");
                    usad=Console.ReadLine();
                    string? psad = "";
                    Console.WriteLine("Enter password : ");
                    psad=Console.ReadLine();
                    for (int i = 0; i < admins.Count; i++)
                    {
                        if (usad==admins[i].NameAdmin && psad==admins[i].PasswordAdmin)
                        {
                            Console.WriteLine("Welcome dear "+admins[i].NameAdmin);
                            Notification nts = new Notification(1, "Like/View count artdi ", "Userden");
                            Console.WriteLine(nts);
                        }

                        
                    }
                }
            }
        }
    }
}