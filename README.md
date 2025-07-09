Voici un modèle de `README.md` clair, structuré et adapté à ton projet de **Game Launcher** :

---

```markdown
# 🎮 GameLauncher – Gestionnaire de Jeux Personnel

> Un launcher de jeux de bureau en C# (.NET WinForms) avec authentification, bibliothèque personnalisée et suivi d’expérience joueur.

## 🚀 Objectif du projet

GameLauncher est une application bureau permettant à un utilisateur de :
- S'enregistrer / Se connecter
- Accéder à son profil joueur
- Gérer sa bibliothèque de jeux (jeux joués, en cours, à venir…)
- Noter, commenter et organiser ses jeux
- Accéder à des informations complémentaires sur chaque jeu
- Naviguer entre les différentes sections via une interface fluide

---

## 🏗️ Technologies utilisées

- **.NET** 9 (WinForms)
- **Entity Framework Core** (SQLite)
- **C#**
- **Git / GitHub**
- UI en WinForms avec logique MVC partielle

---

## 🔧 Fonctionnalités actuelles

- [x] Connexion / Inscription utilisateur
- [x] Hashage sécurisé du mot de passe
- [x] Photo de profil par défaut
- [x] Base de données locale SQLite
- [ ] Bibliothèque de jeux personnalisable
- [ ] Catégorisation, statut, notes privées/publiques
- [ ] Ajout de guides / forums liés à un jeu 
- [ ] Statistiques globales ou sociales

---

## 🗃️ Structure du projet

```

GameLauncher/
│
├── Models/              # Modèles EF Core (User, Game, Note…)
├── Views/               # WinForms (LoginForm, RegisterForm, MainMenu…)
├── Data/                # Database
├── Controllers/         # Logique métier (Register, Login, Navigation…)
├── Services/            # Services partagés (hash, navigation, session…)
├── Helpers/             # Utilitaires (validation, config…)
├── Assets/              # Images, icônes, fichiers statiques
├── appsettings.json     # Configuration EF / Connexion BDD
└── GameLauncher.sln     # Solution principale

```

## Schéma de la base de données

![Diagramme ER](doc/GameLauncherDBSchem.png)

---

## ⚙️ Configuration requise

- .NET 9 SDK
- Visual Studio 2022+ (ou Rider)
- EF Core CLI :
  ```bash
  dotnet tool install --global dotnet-ef
````

---

## 🔄 Lancer l’application

1. Cloner le repo :

   ```bash
   git clone https://github.com/lerouxblond/GameLauncher.git
   cd GameLauncher
   ```

2. Installer les dépendances :

   ```
   dotnet restore
   ```

3. Créer la base de données :

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. Lancer l’application :

   ```bash
   dotnet run
   ```

---

## 📦 À venir

* Authentification persistante (session/remember me)
* Importation manuel des jeux
* Lancement de jeux directement depuis l’app
* Rating, notes, forum et bibliothèque personnelle

---

## 🧠 Apprentissage

Projet réalisé dans un objectif de montée en compétences en :

* C# orienté objet
* Architecture MVC et services
* Manipulation d’Entity Framework
* Création d’une interface graphique utilisateur
* Gestion de projet et organisation Git

---

## 📄 Licence

Code open-source et libre d’usage pour un usage éducatif.

---

```