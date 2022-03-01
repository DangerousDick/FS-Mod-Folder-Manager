#!/usr/bin/python
# Author Richard Sayer
# Copyright (c) 2022 Richard Sayer


import PyInstaller.__main__
import os

# set spec file
workdir = os.getcwd()
ModsManager = os.path.join(workdir, 'ModsManager.spec')

# define the "dev\dist" and "dev\build" dirs
os.chdir("..")
devdir = os.getcwd()
distdir = os.path.join(devdir, 'dist')
builddir = os.path.join(devdir, 'build')

# call pyinstaller directly
PyInstaller.__main__.run(['--distpath', distdir, '--workpath', builddir,
                          '--onefile', '--windowed', '--noconsole', '--clean', ModsManager])
