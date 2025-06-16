# 🛠️ SupportService - Microservice de gestion des réclamations techniques

## 📘 Description

**SupportService** est un microservice développé avec **ASP.NET Core Web API**, destiné à gérer les réclamations techniques d'une entreprise de services (connexion lente, bugs d’applications, etc.).  
Il permet aux utilisateurs de créer et consulter des réclamations via des endpoints REST.

---

## ✅ Fonctionnalités

- 📄 **Modèle Reclamation** :
  - `Id` : identifiant unique
  - `Sujet` : sujet de la réclamation
  - `Description` : description détaillée de la réclamation

- 🔧 **API RESTful** :
  - `GET /reclamations` : Liste toutes les réclamations
  - `POST /reclamations` : Crée une nouvelle réclamation

- 💾 **Connexion à la base de données** via Entity Framework Core
- ⚙️ **Injection de dépendance** du `DbContext` dans les contrôleurs
- 🧪 Fichier `.http` pour tester les endpoints sans Postman

---

## 🚀 Lancer le projet en local

### 1. 📦 Prérequis

- [.NET SDK 7.0 ou supérieur](https://dotnet.microsoft.com/download)
- Visual Studio 2022 ou plus récent
-  SQL Server local

---

### 2. 📁 Cloner le projet

```bash
git clone https://github.com/soundousnidar/SupportService.git
cd SupportService
