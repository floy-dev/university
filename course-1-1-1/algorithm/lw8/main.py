import tkinter


def main():
    window = tkinter.Tk()

    canvas = tkinter.Canvas(window, width=400, height=400)
    canvas.pack()

    window.title("Польша")

    a = canvas.create_oval(50, 50, 300, 300, fill='lightgray', outline="")
    canvas.move(a, 25, 0)

    a = canvas.create_rectangle(100, 120, 300, 170, fill='white', outline="")
    canvas.move(a, 0, 0)
    a = canvas.create_rectangle(100, 170, 300, 220, fill='red', outline="")
    canvas.move(a, 0, 0)

    window.mainloop()


if __name__ == '__main__':
    main()
