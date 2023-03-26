import os
import pathlib
import subprocess


script_directory = str(pathlib.Path(__file__).parent.resolve())
current_directory = str(pathlib.Path().resolve())

py_file_name = input("py file name: ")

result = subprocess.run(['python3.10', '-m' 'pyflowchart', current_directory + '/' + py_file_name, '-f', 'main'],
                        stdout=subprocess.PIPE)

flowchart_code = result.stdout.decode('utf-8')

with open(script_directory + '/' + 'flowchart', 'w') as f:
    f.write(flowchart_code)

diagram_js_name = 'diagrams.js'
path_to_script = script_directory + '/' + diagram_js_name

exec_func = path_to_script + " flowchart " + script_directory + '/' + 'flowchart' + " " + current_directory + \
            "/diagram.svg"

os.system(exec_func)

