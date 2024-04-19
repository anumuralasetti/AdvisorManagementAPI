Advisor Management API
The Advisor Management API is a RESTful web service built using ASP.NET Core for managing advisors in a system. It provides endpoints to perform CRUD (Create, Read, Update, Delete) operations on advisor entities.

Features
Create Advisor: Endpoint to create a new advisor with the specified details.
Get Advisor by ID: Endpoint to retrieve an advisor by its unique identifier.
Update Advisor: Endpoint to update an existing advisor with new information.
Delete Advisor: Endpoint to delete an advisor from the system.
List All Advisors: Endpoint to retrieve a list of all advisors stored in the system.

Access the API endpoints using tools like Postman or cURL:
GET /api/advisor: Retrieve a list of all advisors.
GET /api/advisor/{id}: Retrieve an advisor by ID.
POST /api/advisor: Create a new advisor.
PUT /api/advisor/{id}: Update an existing advisor.
DELETE /api/advisor/{id}: Delete an advisor by ID.
