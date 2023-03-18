import os, time, datetime

path = os.getcwd()  # Ruta de la carpeta que queremos revisar


def gitPush(archive, commit_message="new changes", branch="main"):
    os.system(f"git add {archive}")
    os.system(f'git commit -m "{commit_message}"')
    os.system(f"git push origin {branch}")
    return True


# Obtenemos la lista de archivos y carpetas dentro del archivo .gitignore
def listOfDirectoryIgnore():
    # agregar los archivos comunes de git
    gitCommonded = [
        "config",
        "HEAD",
        "index",
        "FETCH_HEAD",
        "ORIG_HEAD",
        "MERGE_HEAD",
        "refs",
        "logs",
        "info",
        "hooks",
        "description",
        "COMMIT_EDITMSG",
        "logs",
        "stash",
        "packed-refs",
        "objects",
        "branches",
        "origin",
        "master",
        "main",
    ]
    # Si no existe el archivo .gitignore, retornamos una lista vacía
    if not os.path.exists(".gitignore"):
        return []

    with open(".gitignore", "r") as archive:
        archives = archive.read().splitlines()

    for archive in archives:
        if archive == "":
            archives.remove(archive)
            continue
        if archive[-1] == "/":
            archives[archives.index(archive)] = archive[:-1]
    for archive in gitCommonded:
        archives.append(archive)

    return archives


def timesOfArchives(path):
    # Obtenemos la lista de archivos y carpetas dentro de la carpeta
    directory_files = os.walk(path)

    fullDictionary = {}
    for root, dirs, files in directory_files:
        # probar convertirlo en diccionario para que sea mas facil de comparar
        for dir in dirs:
            if (
                dir.startswith(".git")
                or dir in listOfDirectoryIgnore()
                or (os.path.join(root, dir)) == os.path.join(root, ".git")
            ):
                continue
            dir_path = os.path.join(root, dir)
            dir_modification_time = os.stat(dir_path).st_mtime
            fullDictionary[dir] = dir_modification_time
        for file in files:
            if (
                file == ".git"
                or file in listOfDirectoryIgnore()
                or (os.path.join(root, file)) == os.path.join(root, ".git")
            ):
                continue
            file_path = os.path.join(root, file)
            file_modification_time = os.stat(file_path).st_mtime
            fullDictionary[file] = file_modification_time

    # Obtenemos los tiempos de modificación de los archivos en un diccionario
    return fullDictionary

    # List Comprehension
    # [item: <expr> for <elemento> in <lista>]
    # Donde <expr> es una expresión que se evalúa para cada elemento de la lista <lista>.
    # El resultado de <expr> se asigna al elemento con nombre <item>.


def saveModifiedFiles(current_times):
    # Guardamos los tiempos de modificación de los archivos en un archivo
    with open("previous_times.txt", "w") as archive:
        for archives, times in current_times.items():
            archive.write(f"{archives},{times}\n")


def countdown(tiempo):
    # Contador regresivo
    for i in range(tiempo, 0, -1):
        print(f"\033[1;33m/===============( {i} )===============/\033[0m")
        time.sleep(1)
        os.system("clear")


def compareChanges(current_times, new_times):
    listOfChanges = []

    if len(current_times) > len(new_times):
        file_deleted = {
            archive: times
            for archive, times in current_times.items()
            if archive not in new_times
        }

        for archive, times in file_deleted.items():
            if os.path.exists(archive):
                print(f"\033[1;31mSe elimino el archivo {archive}\033[0m")
                print("\033[1;32m")
                gitPush(archive)
                print("\033[1;32m")
                time.sleep(3)
            else:
                print("\033[1;32m")
                finish = gitPush(".")
                if finish:
                    print(f"\033[1;32mSe han subido los cambios a GitHub\033[0m")
                    break
                time.sleep(2)
    elif len(current_times) < len(new_times):
        file_added = {
            archive: times
            for archive, times in new_times.items()
            if archive not in current_times
        }

        for archive, times in file_added.items():
            if os.path.exists(archive):
                print(f"\033[1;31mSe agrego el archivo {archive}\033[0m")
                print("\033[1;32m")
                gitPush(archive)
                print("\033[1;32m")
                time.sleep(3)
            else:
                print("\033[1;32m")
                finish = gitPush(".")
                if finish:
                    print(f"\033[1;32mSe han subido los cambios a GitHub\033[0m")
                    break
                time.sleep(2)

    elif len(current_times) == len(new_times):
        # Recorremos los nuevos tiempos de modificación
        for archive, times in new_times.items():
            if archive in current_times:
                # Si el archivo ya existía, revisamos si el tiempo de modificación ha cambiado
                if times != current_times[archive]:
                    listOfChanges.append(archive)
                    print(f"\033[1;32mEl archivo {archive} ha tenido cambios\033[0m")
                    time.sleep(3)

        if len(listOfChanges) > 0:
            for archive in listOfChanges:
                if os.path.exists(archive):
                    print("\033[1;32m")
                    gitPush(archive)
                    print(
                        f"\033[1;32mSe ha subido el archivo {archive} a GitHub\033[0m"
                    )
                    time.sleep(2)
                else:
                    print("\033[1;32m")
                    finish = gitPush(".")
                    if finish:
                        print(f"\033[1;32mSe han subido los cambios a GitHub\033[0m")
                        break
                    time.sleep(2)
    else:
        print("\033[1;32mNo se ha detectado ningun cambio\033[0m")
        time.sleep(3)


current_times = timesOfArchives(path)

while True:
    new_times = timesOfArchives(path)
    compareChanges(current_times, new_times)
    # Actualizamos los tiempos de modificación
    current_times = new_times
    countdown(5)

""" from github import Github
import os

myGitHub = Github("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")

repositories = []

# Then play with your Github objects:
for repo in myGitHub.get_user().get_repos():
    repositories.append(repo.full_name)

for index in range(0,len(repositories)):
    print(f"\t\033[1;34m{index+1}. {repositories[index]}\033[0m")

option = 0
selected = ""

while True:
    print()
    option = int(input("\t\033[1;35mSelecciona un repositorio: "))
    print("\033[0m")
    if option > 0 and option <= len(repositories):
        selected = repositories[option-1]
        break
    else:
        print("Invalid option")

# Seleccionar el repositorio para el que se subirán los cambios y la rama
repo = myGitHub.get_repo(selected)
#print(dir(repo))

contents = repo.get_contents("ejercicio99.py", ref="main")
repo.update_file(contents.path, "more tests", "more tests", contents.sha, branch= "main")"""
