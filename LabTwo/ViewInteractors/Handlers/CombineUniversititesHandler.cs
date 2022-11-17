﻿using LabTwo.Models.University;
using LabTwo.Warnings;
using static System.Windows.Forms.ListView;

namespace LabTwo.ViewInteractors.Handlers
{
    public class CombineUniversititesHandler
    {
        private Form1 itsMainWindow;
        private bool itsFirstUniversityChosen;
        private University itsFirstUniversity;

        public CombineUniversititesHandler(Form1 mainWindow)
        {
            itsMainWindow = mainWindow;
            itsFirstUniversityChosen = false;
            itsFirstUniversity = null;
            AddColumnsToListView();
        }
        private void AddColumnsToListView()
        {
            itsMainWindow.universitiesToCombineListView.Columns.Add("Name");
            itsMainWindow.universitiesToCombineListView.Columns.Add("Foundation year");
            itsMainWindow.universitiesToCombineListView.Columns.Add("Rank");
        }

        public void ChooseFirstUniversityOrCombineBothUniversities()
        {
            if (itsMainWindow.universitiesToCombineListView.SelectedIndices.Count == 0)
                WarningDisplayer.ShowWarning(itsMainWindow.warningPanel, itsMainWindow.warningTextBox, new List<IWarning>()
                { new UniversityToCombineNotChosen() });
            else
            {
                if (!itsFirstUniversityChosen)
                {
                    itsFirstUniversityChosen = true;
                    SelectedIndexCollection selectedIndexCollection = itsMainWindow.universitiesToCombineListView.SelectedIndices;
                    itsFirstUniversity = itsMainWindow.universityController[selectedIndexCollection[0]];
                    itsMainWindow.chooseUniversityOfCombineBothLabel.Text = "Choose second university:";
                    itsMainWindow.chooseFirstUniversityOfCombineBothButton.Text = "Combine universities";
                }
                else
                {
                    itsFirstUniversityChosen = false;
                    University combination = itsFirstUniversity +
                        itsMainWindow.universityController[itsMainWindow.universitiesToCombineListView.SelectedIndices[0]];
                    itsMainWindow.universityComboBox.Items.Add(itsMainWindow.mainInfoPanelHandler.MainInfoPanelFormStorage.UniversityName);
                    itsMainWindow.chooseUniversityOfCombineBothLabel.Text = "Choose first university:";
                    itsMainWindow.chooseFirstUniversityOfCombineBothButton.Text = "Choose first university:";
                }
            }
        }
    }
}