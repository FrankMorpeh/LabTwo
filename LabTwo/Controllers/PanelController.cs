using LabTwo.ViewInteractors.Handlers;

namespace LabTwo.Controllers
{
    public class PanelController // used to show and hide panels
    {
        private List<IPanelHandler> itsPanelHandlers;

        public PanelController(Form1 mainWindow) 
        {
            itsPanelHandlers = new List<IPanelHandler>() { mainWindow.mainInfoPanelHandler, mainWindow.departmentsInfoPanelHandler
                , mainWindow.subjectsInfoPanelHandler, mainWindow.studentsInfoPanelHandler };
        }

        public void ShowPanel(IPanelHandler panelHandler)
        {
            foreach (IPanelHandler handler in itsPanelHandlers)
            {
                if (handler != panelHandler)
                    handler.HidePanel();
            }
            IPanelHandler panelHandlerToShow = itsPanelHandlers.Where(ph => ph == panelHandler).SingleOrDefault();
            panelHandlerToShow.ShowPanel();
        }
        public void HidePanelsExceptFor(IPanelHandler panelHandler)
        {
            foreach (IPanelHandler handler in itsPanelHandlers)
            {
                if (handler != panelHandler)
                    handler.HidePanel();
            }
        }
    }
}