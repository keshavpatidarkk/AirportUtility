# AirportUtility

**AirportUtility** is a .NET Core 6.0 Web API project designed to provide information about various airports. The project follows a layered architecture to separate responsibilities and maintain a clean and organized codebase.

## Code Structure

The project's codebase is organized as follows:

- **Controllers**: This directory contains the API controllers responsible for handling client requests and generating responses.

- **Contracts**: The Contracts directory houses interfaces that are used by the Business Logic Layer (BLL) and Data Service Layer (DAL).

- **Business**: Within the Business directory, you'll find classes responsible for handling business logic. These classes serve as the core of the application, processing client requests.

- **DataService**: The DataService directory provides access to airport data from various sources. It acts as a bridge between the business logic and data sources.

- **Middleware**: The Middleware directory contains custom middleware, primarily a logging middleware. This middleware logs incoming requests and outgoing responses, which can be useful for tracking and debugging purposes.

- **Models**: This directory holds model classes used to represent and structure data within the application.

## How to Use

To use this project, you can follow these steps:

1. Clone the repository to your local machine.
2. Ensure you have the required dependencies and tooling, such as .NET Core 6.0, installed.
3. Build and run the project using your preferred development environment.
4. Access the API endpoints provided by the controllers to retrieve airport information.

Feel free to explore the codebase, customize it to suit your specific requirements, and extend the functionalities as needed.

## Contributing

We welcome contributions from the community. If you have ideas for improvements, new features, or bug fixes, please consider opening an issue or submitting a pull request.

## License

This project is licensed under the [MIT License](LICENSE), so you are free to use and modify it as needed.

Enjoy using **AirportUtility**!

---

*Note: This README is a template. Please update it with specific information about your project, including installation instructions, usage examples, and any additional documentation.*
