class ICommand():
    def execute(self):
        pass


class Document:
    def open(self):
        print("Document Opened")

    def save(self):
        print("Document Saved")

    def close(self):
        print("Document Closed")


class OpenCommand(ICommand):
    def __init__(self, document):
        self.document = document

    def execute(self):
        self.document.open()


class SaveCommand(ICommand):
    def __init__(self, document):
        self.document = document

    def execute(self):
        self.document.save()


class CloseCommand(ICommand):
    def __init__(self, document):
        self.document = document

    def execute(self):
        self.document.close()


class MenuOptions:
    def __init__(self, open_command, save_command, close_command):
        self.open_command = open_command
        self.save_command = save_command
        self.close_command = close_command

    def click_open(self):
        self.open_command.execute()

    def click_save(self):
        self.save_command.execute()

    def click_close(self):
        self.close_command.execute()


# Test
document = Document()
open_command = OpenCommand(document)
save_command = SaveCommand(document)
close_command = CloseCommand(document)
menu = MenuOptions(open_command, save_command, close_command)
menu.click_open()
menu.click_save()
menu.click_close()