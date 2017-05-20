
import java.awt.event.*;
import java.awt.*;

import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import javax.swing.JCheckBoxMenuItem;
import javax.swing.KeyStroke;

import javax.swing.JFileChooser;

import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class menuDemo extends JFrame implements ActionListener {

	private final String APP_NAME = "Menu Demonstration Program";

	private int frameWidth = 500;
	private int frameHeight = 500;

	private Toolkit toolkit;

	// constructor
	public menuDemo() {

		// setup the container frame
		this.setSize(this.frameWidth, this.frameHeight); // set initial size
		this.setTitle(this.APP_NAME);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);

		// centre the frame on the screen
		toolkit = getToolkit();
		Dimension size = toolkit.getScreenSize();
		this.setLocation((size.width - getWidth())/2, (size.height - getHeight())/2);

		this.setJMenuBar( this.createMenuBar() );

		// ---------------------------------------------------------------------
		

        //this.pack();
		this.setVisible(true);
	} // end of constructor


	public JMenuBar createMenuBar() {
		JMenuBar menuBar = new JMenuBar();

        menuBar.add( this.createFileMenu() );
        menuBar.add( this.createEditMenu() );
        menuBar.add( this.createFormatMenu() );
        menuBar.add( this.createViewMenu() );
        menuBar.add( this.createHelpMenu() );

		return menuBar;
	}

	public JMenu createFileMenu() {
		JMenu menu = new JMenu("File");
		menu.setMnemonic(KeyEvent.VK_F);

		JMenuItem menuItem;

        menuItem = new JMenuItem("New");
        menuItem.setMnemonic(KeyEvent.VK_N);
        menuItem.setAccelerator( KeyStroke.getKeyStroke( KeyEvent.VK_N, ActionEvent.CTRL_MASK ) );
        menuItem.setEnabled(false);
        menu.add(menuItem);

        menuItem = new JMenuItem("Open...");
        menuItem.setMnemonic(KeyEvent.VK_O);
        menuItem.setAccelerator( KeyStroke.getKeyStroke( KeyEvent.VK_O, ActionEvent.CTRL_MASK ) );
        menuItem.addActionListener(this);
        menu.add(menuItem);

        menuItem = new JMenuItem("Save");
        menuItem.setMnemonic(KeyEvent.VK_S);
        menuItem.setAccelerator( KeyStroke.getKeyStroke( KeyEvent.VK_S, ActionEvent.CTRL_MASK ) );
        menuItem.addActionListener(this);
        menu.add(menuItem);

        menuItem = new JMenuItem("Save As...");
        menuItem.setMnemonic(KeyEvent.VK_A);
        menuItem.addActionListener(this);
        menu.add(menuItem);

        menu.addSeparator();

        menuItem = new JMenuItem("Page Setup...");
        menuItem.setMnemonic(KeyEvent.VK_U);
        menuItem.setEnabled(false);
        menu.add(menuItem);

        menuItem = new JMenuItem("Print...");
        menuItem.setMnemonic(KeyEvent.VK_P);
        menuItem.setAccelerator( KeyStroke.getKeyStroke( KeyEvent.VK_P, ActionEvent.CTRL_MASK ) );
        menuItem.setEnabled(false);
        menu.add(menuItem);

        menu.addSeparator();

        menuItem = new JMenuItem("Exit");
        menuItem.setMnemonic(KeyEvent.VK_X);
        menuItem.addActionListener(this);
        menu.add(menuItem);

        return menu;
	}

	public JMenu createEditMenu() {
		JMenu menu = new JMenu("Edit");
        menu.setMnemonic(KeyEvent.VK_E);

        return menu;
	}

	public JMenu createFormatMenu() {
		JMenu menu = new JMenu("Format");
        menu.setMnemonic(KeyEvent.VK_F);

        JMenuItem menuItem;
        JCheckBoxMenuItem cbMenuItem;

        cbMenuItem = new JCheckBoxMenuItem("Word Wrap");
        cbMenuItem.setMnemonic(KeyEvent.VK_W);
        menu.add(cbMenuItem);

        menuItem = new JMenuItem("Font...");
        menuItem.setMnemonic(KeyEvent.VK_F);
        menu.add(menuItem);

        return menu;
	}

	public JMenu createViewMenu() {
		JMenu menu = new JMenu("View");
        menu.setMnemonic(KeyEvent.VK_V);

		JMenuItem menuItem;

 		menuItem = new JMenuItem("Status Bar");
        menuItem.setMnemonic(KeyEvent.VK_S);
        menuItem.setEnabled(false);
        menu.add(menuItem);

        return menu;
	}

	public JMenu createHelpMenu() {
		JMenu menu = new JMenu("Help");
        menu.setMnemonic(KeyEvent.VK_H);

        JMenuItem menuItem;

        menuItem = new JMenuItem("View Help");
        menuItem.setMnemonic(KeyEvent.VK_H);
        menu.add(menuItem);

        menu.addSeparator();

        menuItem = new JMenuItem("About " + this.APP_NAME);
        menuItem.setMnemonic(KeyEvent.VK_A);
        menu.add(menuItem);

        return menu;
	}

	public void actionPerformed(ActionEvent event) {
		if (event.getActionCommand().equals("New")) {
			System.out.println("File|New selected");
		} else if (event.getActionCommand().equals("Open...")) {
			this.fileOpen();
		} else if (event.getActionCommand().equals("Save")) {
			System.out.println("File|Save selected");
		} else if (event.getActionCommand().equals("Save As...")) {
			this.fileSaveAs();
		} else if (event.getActionCommand().equals("Page Setup...")) {
			System.out.println("File|Page Setup... selected");
		} else if (event.getActionCommand().equals("Print...")) {
			System.out.println("File|Print selected");
		} else if (event.getActionCommand().equals("Exit")) {
			this.fileExit();
		}
	}

	private void fileOpen() {
		JFileChooser fc = new JFileChooser();
		
		int returnVal = fc.showOpenDialog(this);
		if ( returnVal == JFileChooser.APPROVE_OPTION ) {
			java.io.File file = fc.getSelectedFile();
			// This is where a real application would open the file.
			System.out.println("Opening: " + file.getName());
		} else {
			System.out.println("Open command cancelled by user.");
		}
	}

	private void fileSave() {
		// This is where a real application would save the file.
		System.out.println("Saving the file.");
	}

	private void fileSaveAs() {
		JFileChooser fc = new JFileChooser();
		int returnVal = fc.showSaveDialog(this);
		if ( returnVal == JFileChooser.APPROVE_OPTION ) {
			java.io.File file = fc.getSelectedFile();
			// This is where a real application would save as the file.
			System.out.println("Saving file as: " + file.getName());
		} else {
			System.out.println("Save As command cancelled by user.");
		}
	}

	private void filePageSetup() {
		System.out.println("Open the Java Tutorial:");
		System.out.println("   2D Graphics");
		System.out.println("      Printing");
		System.out.println("         using Print Setup Dialogs");
	}

	private void filePrint() {
		System.out.println("Open the Java Tutorial:");
		System.out.println("   2D Graphics");
		System.out.println("      Printing");
		System.out.println("         using Print Setup Dialogs");
	}

	private void fileExit() {
		String message = "Do you want to Exit the application?";
		int choice = JOptionPane.showConfirmDialog( this, message, this.APP_NAME,
													JOptionPane.YES_NO_OPTION,
													JOptionPane.WARNING_MESSAGE, null);
		if (choice == 0) {
			System.exit(0);
		}
	}


} // end of class MenuDemo