# Cracking the LeetCode

<p align="center">
  <img src="img/leetcode_logo.png" width="1200"  alt="LeetCode Logo"/>
</p>


[![Build PDF](https://github.com/kolosovpetro/CrackingTheLeetCode/actions/workflows/build-pdf.yml/badge.svg)](https://github.com/kolosovpetro/CrackingTheLeetCode/actions/workflows/build.yml/badge.svg)
[![Build and Deploy PDF](https://github.com/kolosovpetro/CrackingTheLeetCode/actions/workflows/build-and-deploy-pdf.yml/badge.svg)](https://github.com/kolosovpetro/CrackingTheLeetCode/actions/workflows/build-and-deploy.yml/badge.svg)
[![Build Csharp Solution](https://github.com/kolosovpetro/CrackingTheLeetCode/actions/workflows/build-csharp.yml/badge.svg)](https://github.com/kolosovpetro/CrackingTheLeetCode/actions/workflows/build-csharp.yml/badge.svg)
![contributors count](https://img.shields.io/github/contributors/kolosovpetro/CrackingTheLeetCode)

## Build and run

- Install MikTeX: https://miktex.org/download
- Update MikTeX
- Install SumatraPDF viewer: https://www.sumatrapdfreader.org/download-free-pdf-viewer
- Install Intellij IDEA Ultimate: https://www.jetbrains.com/idea/download/#section=windows
- Activate Intellij IDEA Ultimate
- Install TeXiFy IDEA plugin: https://plugins.jetbrains.com/plugin/9473-texify-idea
- Fork this repository
- Clone your fork repository locally: `git clone https://github.com/kolosovpetro/CrackingTheLeetCode.git`
- Fetch your local fork and update it locally:
    - `git checkout develop`
    - `git pull`
- Open project folder with Intellij IDEA
- Configure Inverse Search in IDEA for SumatraPDF: `Tools -> LaTeX -> Configure Inverse Search`
- Add build configurations for `LaTeX` and `bibTeX`
- Compile document using `Shift + F10`

## Contribution

In order to contribute proceed as follows:

- Watch and decide which issue to solve, each issue has an ID `LEETCODE-ID` to be used in branch naming
- Fetch tasks category at: https://seanprashad.com/leetcode-patterns/
- Fork this repository
- Clone this repository using `git clone https://github.com/${{ username }}/CrackingTheLeetCode.git`
- If repository is cloned already then pull last changes from `develop` using
  - `git checkout develop`
  - `git pull`
- Create new branch based on `develop` with name according to `LEETCODE-ID` of an issue
- Solve the issue
- Create pull request to `develop` from your fork