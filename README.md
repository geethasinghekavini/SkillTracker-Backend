# SkillTrackr Backend 

This is the backend API for **SkillTrackr**, a skill progress tracking system built using **ASP.NET Core 8 Web API**, **Entity Framework Core**, and **Clean Architecture principles**. It exposes REST endpoints for managing skills and progress logs.

---

##  Tech Stack

- ASP.NET Core 8 Web API
- Entity Framework Core
- PostgreSQL (or SQL Server)
- AutoMapper
- FluentValidation
- MediatR
- Serilog
- Swagger (OpenAPI)

---

##  Project Structure

SkillTrackr/
├── SkillTrackr.WebApi/ # Main API entry point
├── SkillTrackr.Application/ # Application logic (DTOs, interfaces, MediatR)
├── SkillTrackr.Domain/ # Domain models & entities
└── SkillTrackr.Infrastructure/ # Persistence & DBContext
