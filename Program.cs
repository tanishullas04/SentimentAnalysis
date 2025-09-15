using System;

namespace ProductAnalysis
{
    class Admin
    {
        public int AdminID;
        public string AdminName;

        public bool Login()
        {
            Console.Write("Enter Admin ID: ");
            int enteredID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Admin Name: ");
            string enteredName = Console.ReadLine();

            if (enteredID == 123 && enteredName == "Admin")
            {
                Console.WriteLine("\nAdmin Login Successful!\n");
                return true;
            }
            Console.WriteLine("\nLogin Failed! Invalid credentials.");
            return false;
        }
    }

    class User
    {
        public int UserID;
        public string UserName;

        public void GetUserDetails()
        {
            Console.WriteLine("\n--- User Details ---");
            Console.WriteLine("User ID: " + UserID);
            Console.WriteLine("User Name: " + UserName);
        }

    }

    class Category
    {
        public int CategoryID;
        public string CategoryName;
    }

    class Product
    {
        public int ProductID;
        public string ProductName;
        public Category ProductCategory;

        public void GetProductDetails()
        {
            Console.WriteLine("\n--- Product Details ---");
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Category: " + ProductCategory.CategoryName);
        }

    }

    class Review
    {
        public User Reviewer;
        public Product ReviewedProduct;
        public int Rating;
        public string Comment;

        public void AnalyzeSentiment()
        {
            // Define positive and negative words
            string[] positiveWords = { "good", "excellent", "amazing", "great", "happy", "love", "best", "awesome" };
            string[] negativeWords = { "bad", "terrible", "worst", "sad", "awful", "poor", "hate", "disappointing" };

            int positiveCount = 0, negativeCount = 0;
            string reviewText = Comment.ToLower();  // Convert to lowercase for case-insensitive matching

            // Count occurrences of positive words
            foreach (string word in positiveWords)
            {
                if (reviewText.Contains(word)) positiveCount++;
            }

            // Count occurrences of negative words
            foreach (string word in negativeWords)
            {
                if (reviewText.Contains(word)) negativeCount++;
            }

            // Determine sentiment
            string sentiment;
            if (positiveCount > negativeCount)
                sentiment = "Positive Review";
            else if (negativeCount > positiveCount)
                sentiment = "Negative Review";
            else
                sentiment = "Neutral Review";

            // Display sentiment result
            Console.WriteLine("\n--- Sentiment Analysis ---");
            Console.WriteLine("Review Sentiment: " + sentiment);
        }
    }

    class Feedback
    {
        public string FeedbackOption;

        public void GetFeedback()
        {
            while (true)
            {
                Console.WriteLine("\n--- Select Feedback Option ---");
                Console.WriteLine("1. Matches the product images and description");
                Console.WriteLine("2. Arrived on time.");
                Console.WriteLine("3. Difficult to contact support.");
                Console.WriteLine("4. Missing parts or accessories.");
                Console.WriteLine("5. Worth the price.");

                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    FeedbackOption = "Matches the product images and description";
                    break;
                }
                else if (choice == 2)
                {
                    FeedbackOption = "Arrived on time.";
                    break;
                }
                else if (choice == 3)
                {
                    FeedbackOption = "Difficult to contact support.";
                    break;
                }
                else if (choice == 4)
                {
                    FeedbackOption = "Missing parts or accessories.";
                    break;
                }
                else if (choice == 5)
                {
                    FeedbackOption = "Worth the price.";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
                }
            }
        }
    }
    class DBA
    {
        public int DBAID;
        public string DBAName;

        public bool Login()
        {
            Console.Write("Enter DBA ID: ");
            int enteredID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter DBA Name: ");
            string enteredName = Console.ReadLine();

            if (enteredID == 456 && enteredName == "DBA")
            {
                Console.WriteLine("\nDBA Login Successful!\n");
                return true;
            }
            Console.WriteLine("\nLogin Failed! Invalid credentials.");
            return false;
        }
    }

    class Supplier
    {
        public int SupplierID;
        public string SupplierName;

        public void GetSupplierDetails()
        {
            Console.WriteLine("\n--- Supplier Details ---");
            Console.WriteLine("Supplier ID: " + SupplierID);
            Console.WriteLine("Supplier Name: " + SupplierName);
        }

        class Report
        {
            public void GenerateReport(User user, Product product, Review review, Feedback feedback)
            {
                Console.WriteLine("\n--- Product Report ---");
                Console.WriteLine("User ID: " + user.UserID);
                Console.WriteLine("User Name: " + user.UserName);
                Console.WriteLine("Product: " + product.ProductName);
                Console.WriteLine("Category: " + product.ProductCategory.CategoryName);
                Console.WriteLine("Rating: " + review.Rating + "/5");
                Console.WriteLine("Review Comment: " + review.Comment);
                Console.WriteLine("Feedback: " + feedback.FeedbackOption);
            }
        }


        class Program
        {
            public static void Main()
            {
                Console.WriteLine("Login as: \n1. Admin\n2. User\n3. DBA\n4. Supplier");
                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Admin admin = new Admin();
                        if (!admin.Login()) return;

                        Category category = new Category();
                        Console.Write("Enter Category ID: ");
                        category.CategoryID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Category Name: ");
                        category.CategoryName = Console.ReadLine();

                        Product product = new Product();
                        Console.Write("Enter Product ID: ");
                        product.ProductID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Product Name: ");
                        product.ProductName = Console.ReadLine();
                        product.ProductCategory = category;
                        break;

                    case 2:
                        User user = new User();
                        Console.Write("Enter User ID: ");
                        user.UserID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter User Name: ");
                        user.UserName = Console.ReadLine();

                        Product reviewProduct = new Product();
                        Console.Write("Enter Product Name to Review: ");
                        reviewProduct.ProductName = Console.ReadLine();

                        Category reviewCategory = new Category();
                        Console.Write("Enter Product Category: ");
                        reviewCategory.CategoryName = Console.ReadLine();
                        reviewProduct.ProductCategory = reviewCategory;

                        Review userReview = new Review { Reviewer = user, ReviewedProduct = reviewProduct };

                        Console.Write("Enter Rating (1-5): ");
                        while (true)
                        {
                            int rating = Convert.ToInt32(Console.ReadLine());
                            if (rating >= 1 && rating <= 5)
                            {
                                userReview.Rating = rating;
                                break;
                            }
                            Console.WriteLine("Invalid rating! Please enter a number between 1 and 5.");
                        }

                        Console.Write("Enter Review Comment: ");
                        userReview.Comment = Console.ReadLine();
                        userReview.AnalyzeSentiment();

                        Feedback feedback = new Feedback();
                        feedback.GetFeedback();
                        Console.WriteLine("User Feedback: " + feedback.FeedbackOption);

                        Console.Write("Do you want to generate a report? (yes/no): ");
                        string generateReport = Console.ReadLine().ToLower();

                        if (generateReport == "yes")
                        {
                            Report report = new Report();
                            report.GenerateReport(user, reviewProduct, userReview, feedback);
                        }
                        break;

                    case 3:
                        DBA dba = new DBA();
                        if (!dba.Login()) return;
                        break;

                    case 4:
                        Supplier supplier = new Supplier();
                        Console.Write("Enter Supplier ID: ");
                        supplier.SupplierID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Supplier Name: ");
                        supplier.SupplierName = Console.ReadLine();
                        supplier.GetSupplierDetails();
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                        break;

                }
            }
        }
    }
}