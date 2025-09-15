# Product Analysis and Sentiment Analysis System

## Overview
This C# console application implements a comprehensive product analysis system with sentiment analysis capabilities. The system allows multiple user roles to interact with the platform, manage products, and analyze customer reviews using sentiment analysis.

## Features

### 1. Multi-Role Authentication System
- **Admin Access** (ID: 123, Name: "Admin")
  - Can manage product categories
  - Add new products to the system
  - View product details

- **User Access**
  - Submit product reviews
  - Provide ratings (1-5 scale)
  - Give structured feedback
  - Generate detailed reports

- **DBA Access** (ID: 456, Name: "DBA")
  - Database administrator access
  - System maintenance capabilities

- **Supplier Access**
  - Manage supplier information
  - View supplier-specific details

### 2. Product Management
- Hierarchical product categorization
- Detailed product information tracking
- Category-based organization
- Product-category relationship management

### 3. Review System
- **Rating Component**
  - Numerical ratings (1-5 scale)
  - Written comments
  - Structured feedback options

- **Feedback Options**
  1. Product description accuracy
  2. Delivery timeliness
  3. Customer support accessibility
  4. Product completeness
  5. Price-value assessment

### 4. Sentiment Analysis Engine
The system includes a sophisticated sentiment analysis engine that:
- Processes review comments for emotional content
- Uses predefined sentiment dictionaries
- Identifies positive and negative sentiments
- Analyzes the following keywords:

**Positive Keywords:**
- good
- excellent
- amazing
- great
- happy
- love
- best
- awesome

**Negative Keywords:**
- bad
- terrible
- worst
- sad
- awful
- poor
- hate
- disappointing

### 5. Reporting System
Generates comprehensive reports including:
- User information
- Product details
- Category classification
- Rating scores
- Review comments
- Feedback selections
- Sentiment analysis results

## Technical Implementation

### Class Structure
1. **Admin Class**
   - Handles administrative authentication
   - Manages product and category creation

2. **User Class**
   - Manages user information
   - Handles user detail display

3. **Category Class**
   - Stores category information
   - Links products to categories

4. **Product Class**
   - Maintains product information
   - Links to category information

5. **Review Class**
   - Processes user reviews
   - Implements sentiment analysis
   - Links users to products

6. **Feedback Class**
   - Manages structured feedback options
   - Implements feedback collection logic

7. **DBA Class**
   - Handles database administrator access
   - Manages system maintenance

8. **Supplier Class**
   - Manages supplier information
   - Handles supplier detail display

### Sentiment Analysis Algorithm
The sentiment analysis works by:
1. Converting review text to lowercase
2. Counting occurrences of positive and negative keywords
3. Comparing positive vs negative word frequencies
4. Determining overall sentiment (Positive, Negative, or Neutral)

## Usage Instructions

### 1. Starting the Application
1. Ensure you have [.NET SDK](https://dotnet.microsoft.com/download) installed
2. Open a terminal in the project directory
3. Build and run the application:
   ```zsh
   dotnet run Program.cs
   ```
4. Select your role from the menu:
   ```
   Login as:
   1. Admin
   2. User
   3. DBA
   4. Supplier
   ```

### 2. Role-Specific Operations

#### For Admins:
1. Enter Admin credentials (ID: 123, Name: "Admin")
2. Add category information
3. Create new products

#### For Users:
1. Enter user details
2. Select product to review
3. Provide rating and review
4. Select feedback option
5. Generate report (optional)

#### For DBAs:
1. Enter DBA credentials (ID: 456, Name: "DBA")
2. Perform system maintenance

#### For Suppliers:
1. Enter supplier information
2. View supplier details

## Data Validation
- Rating validation (must be between 1-5)
- Required credential validation for Admin and DBA
- Structured feedback selection validation

## Security Features
- Role-based access control
- Credential verification for admin and DBA access
- Input validation across all user inputs

## Project Structure
- `Program.cs`: Contains all the classes and main program logic
  - Admin, User, Category, Product classes
  - Review and Feedback functionality
  - Sentiment analysis implementation
  - Report generation system

## Future Enhancements
Potential areas for improvement:
1. Enhanced sentiment analysis with machine learning
2. Database integration
3. User session management
4. More sophisticated reporting capabilities
5. Advanced security features
6. API integration capabilities
7. Multi-language support

## System Requirements
- .NET Framework
- C# development environment
- Console-based interface support

## Contributing
Feel free to fork this project and submit pull requests for any enhancements.

## License
This project is for educational/demo purposes.

---
Last Updated: September 15, 2025
