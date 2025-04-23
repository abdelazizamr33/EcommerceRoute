# 🛒 E-Commerce Web API (ASP.NET Core)

This project is a **modern E-Commerce Web API** built using **ASP.NET Core**, designed with a strong focus on **clean architecture, scalability, and performance**. It's still in progress, but already packed with robust backend features that support an online store's essential operations.

---

## 🛠️ Tech Stack & Architecture

This API is structured using **Onion Architecture** for a clear separation of concerns and maintainability. It includes:

- **ASP.NET Core Web API**  
- **Entity Framework Core**  
- **SQL Server** for database storage  
- **Redis** for distributed caching (used in the basket module)  

### Design Patterns Implemented

- **Dependency Injection (D.I.)**  
- **Unit of Work**  
- **Generic Repository Pattern**  
- **Specification Pattern** for advanced querying  

---

## 🔐 Authentication & Authorization

- Full **Authorization** system in place to control access to protected endpoints  
- **Login & Registration** endpoints implemented and secure  

---

## 🛍️ Features

- **Basket Module**  
  Redis-backed cart functionality for storing user selections before checkout.

- **Caching Service**  
  Uses Redis for performance-optimized data retrieval and minimized DB load.

- **Global Exception Handling**  
  Handles and logs all types of exceptions centrally to ensure consistent and safe error responses.

---

## ⚙️ In Progress

This project is still under development. Planned upcoming features  

---

## 📬 Contact

For any questions or collaboration opportunities, feel free to reach out via [LinkedIn](https://www.linkedin.com/in/abdelazizamr33/) or GitHub issues.
