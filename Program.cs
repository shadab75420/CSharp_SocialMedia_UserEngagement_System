using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialMediaPlatform
{
    class UserEngagementSystem
    {
        private List<string> posts = new List<string>();
        private Dictionary<string, int> likes = new Dictionary<string, int>();
        private HashSet<int> userIds = new HashSet<int>();
        private Stack<string> recentActions = new Stack<string>();
        private Queue<string> notifications = new Queue<string>();

        public void AddUser(int userId)
        {
            if (userIds.Add(userId))
            {
                recentActions.Push($"User {userId} added");
            }
            else
            {
                Console.WriteLine($"User {userId} already exists.");
            }
        }

        public void AddPost(string post)
        {
            posts.Add(post);
            likes[post] = 0;
            recentActions.Push($"Post added: {post}");
            notifications.Enqueue($"New post created: {post}");
        }

        public void LikePost(string post)
        {
            if (likes.ContainsKey(post))
            {
                likes[post]++;
                recentActions.Push($"Post liked: {post}");
                notifications.Enqueue($"Post liked: {post}");
            }
        }

        public void UndoLastAction()
        {
            if (recentActions.Count > 0)
            {
                string lastAction = recentActions.Pop();
                Console.WriteLine($"Undo: {lastAction}");
            }
        }

        public void ProcessNotifications()
        {
            Console.WriteLine("Processing Notifications:");
            while (notifications.Count > 0)
            {
                Console.WriteLine(notifications.Dequeue());
            }
        }

        public void ShowPosts()
        {
            Console.WriteLine("Posts and Likes:");
            foreach (var post in posts)
            {
                Console.WriteLine($"{post} - Likes: {likes[post]}");
            }
        }

        public void ShowUsers()
        {
            Console.WriteLine("Users:");
            foreach (var userId in userIds)
            {
                Console.WriteLine($"User ID: {userId}");
            }
        }

        public void ShowRecentActions()
        {
            Console.WriteLine("Recent Actions:");
            foreach (var action in recentActions.Reverse())
            {
                Console.WriteLine(action);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserEngagementSystem system = new UserEngagementSystem();

            system.AddUser(1);
            system.AddUser(2);
            system.AddUser(1);

            system.AddPost("Just finished my morning run!");
            system.AddPost("Excited about the new tech release!");

            system.LikePost("Just finished my morning run!");
            system.LikePost("Just finished my morning run!");
            system.LikePost("Excited about the new tech release!");

            system.UndoLastAction();

            system.ProcessNotifications();

            system.ShowUsers();
            system.ShowPosts();
            system.ShowRecentActions();
        }
    }
}
