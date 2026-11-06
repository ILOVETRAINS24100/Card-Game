package main;

import javax.swing.*;

public class Main {
    public static void main(String[] args) {
        JFrame frame = new JFrame();
        frame.setSize(800, 600);
        frame.setTitle("Card Game - A Scratch Port - Original By nomishark");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setResizable(false);
        frame.setLayout(null);

        JTextArea desc = new JTextArea("Lore(spoilers) one day you were sitting on a bench when you fall in to the black area. Where a god will call you. Where you have to roll some cards and buy upgrades to escape the abyss or you could stay and become the best card roller in the abyss. End of lore. Start of spoilers if you stay in the abyss when the phone ask you the phone asks at 1,000,000 over all points you get a prestige like system with more upgrade for you that is why it takes so long to get there. End of spoilers.\n\n\n\n\nThis was originally a scratch game, and I am bringing it to java.");
        desc.setBounds(425, 25, 325, 500);
        desc.setLineWrap(true);
        desc.setWrapStyleWord(true);
        desc.setEditable(false);
        frame.add(desc);

        frame.setVisible(true);
    }
}