Post post = new Post();
post.SetPost();
post.AddLike();
for (int i = 0; i < post.Comments.Length; i++)
   {
    post.Comments[i] = System.Console.ReadLine();
   }  

System.Console.WriteLine("Text = "  + post.Text );
System.Console.WriteLine("Likes = " + post.Likes);
System.Console.WriteLine();
System.Console.WriteLine("Comments : " );
System.Console.WriteLine(post.AddComment(post.Comments));
  public class Post
{
public  string Text;
public int Likes;
public string[] Comments = new string[2];
 
 public string SetPost()
 {
     return Text =  System.Console.ReadLine();
 }
 public int AddLike ()
 {
   return Likes =  Convert.ToInt32(System.Console.ReadLine());
 }
 public string AddComment(string[] Comments)
 {
   for (int i = 0; i < Comments.Length; i++)
   {
    System.Console.WriteLine(Comments[i]);
   }
   return Comments[Comments.Length];
 }

}


