
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;


namespace BlankAddin
{
    /// <summary>
    /// Our solidworks taskpane add-in
    /// </summary>
    public class TaskpaneIntegration : ISwAddin
    {
        #region Private Members

        private int mSwCookie;
        private TaskpaneViewHandler mTaskpaneView;


        private TaskpaneHostUI mTaskpaneHost;
        private SldWorks mSolidworksApplication;


        

        #endregion


        #region Public Members

        public const string SWTASKPANE_PROGID = "BlankAddin.TaskpaneHost";

        #endregion


        public bool ConnectToSW(object ThisSW, int Cookie)
        {
            throw new NotImplementedException();
        }

        public bool DisconnectfromSW()
        {
            throw new NotImplementedException();
        }


    }
}
