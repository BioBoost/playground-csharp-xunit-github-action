# CSharp xUnit Test Github Action Workflow

Playground to test GitHub action for running xUnit tests and generating report. Should come in handy for C# evaluations.

Based on [https://dev.to/kurtmkurtm/testing-net-core-apps-with-github-actions-3i76](https://dev.to/kurtmkurtm/testing-net-core-apps-with-github-actions-3i76)

## Not working

Should probable take this approach

```yaml
# This is a basic workflow to help you get started with Actions

name: Build GH Pages

# Controls when the action will run. Triggers the workflow on push or pull request
# events but only for the master branch
on:
  push:
    branches: ['master']
    paths: 'build/*.json'

# A workflow run is made up of one or more jobs that can run sequentially or in parallel
jobs:
  # This workflow contains a single job called "build"
  build:
    # The type of runner that the job will run on
    runs-on: ubuntu-latest

    # Steps represent a sequence of tasks that will be executed as part of the job
    steps:
    # Checks-out your repository under $GITHUB_WORKSPACE, so your job can access it
    - uses: actions/checkout@v2

    # Runs commands using the runners shell
    - name: Run the build php script
      run: |
        cd build
        php build.php # This file reads a few json files and then creates a set of html files in the doc folder
        cd ../
    - name: Commit files # transfer the new html files back into the repository
      run: |
        git config --local user.name "jpadfield"
        git add ./docs
        git commit -m "Updating the repository GitHub html pages in the docs folder"
    - name: Push changes # push the output folder to your repo
      uses: ad-m/github-push-action@master
      with:
        github_token: ${{ secrets.GITHUB_TOKEN }}
        force: true
```