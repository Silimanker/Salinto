# Salinto

Salinto is a web app for Filipino employees and job seekers who want to know what a company is really like before they apply or accept an offer. People can look up companies, read anonymous reviews from other workers, compare salaries, and check basic labor compliance details.

Job hunting in the Philippines comes with its own questions. Is this a direct hire, agency hired, or project based role? Will the 13th month pay actually arrive? Are SSS, PhilHealth and Pag-IBIG contributions being remitted? Salinto puts that kind of information in one place so the decision is a little less of a guess.

## Built with

- C# and Blazor 
- HTML
- Pure CSS

## Pages

| Page | Route |
| --- | --- |
| Log in | `/` or `/login` |
| Register | `/register` |
| Dashboard | `/dashboard` |
| Company details | `/company` |
| Profile | `/profile` |
| Settings | `/settings` |

## Project structure

```
Salinto/
  Program.cs
  App.razor
  Routes.razor
  _Imports.razor
  Layout/         main layout with the top nav, and the login/register layout
  Pages/
    Auth/         Login, Register
    Dashboard/    Dashboard
    Companies/    CompanyDetails
    Account/      Profile, Settings
  wwwroot/css/
    tokens.css       colors and shared values
    base.css         typography and small helpers
    layout.css       top bar, page grid, auth screen, footer
    forms.css        buttons, inputs, fields
    components.css   lists, stats, reviews, salary bars, compliance
```

