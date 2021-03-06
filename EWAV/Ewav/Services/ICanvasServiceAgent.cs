﻿using System;
using System.Net;
using System.ServiceModel.DomainServices.Client;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using EWAV.DTO;
using EWAV.Web.Services;
using System.Collections.Generic;
using EWAV.Web.Services.CanvasDomainService;
using EWAV.Web.Services.CanvasDomainService;

namespace EWAV.Services
{
    public interface ICanvasServiceAgent
    {
        void GetCanvasSharedStatusWithGuid(string canvasGUID,      
            Action<List<CanvasShareStatusDto>, Exception> completed);

        /// <summary>
        /// Gets the canvas shared status.
        /// </summary>
        /// <param name="canvasId">The canvas id.</param>
        /// <param name="organizationId">The organization id.</param>
        /// <param name="canvasSharedStatusCompleted">The canvas shared status completed.</param>
        void GetCanvasSharedStatus(int canvasId, int organizationId, Action<List<CanvasShareStatusDto>, Exception> completed);    

        /// <summary>
        /// Saves the canvas snapshot.
        /// </summary>
        /// <param name="canvasSnapshotAsBase64">The canvas snapshot as base64.</param>
        /// <param name="completed">The completed.</param>
        void SaveCanvasSnapshot(CanvasDto cdto, Action<string, Exception> completed);

        void SaveCanvas(CanvasDto canvasDto, Action<int, Exception> completed);

        void LoadCanvas(int canvasId, Action<CanvasDto, Exception> completed);



        void LoadCanvas(Guid canvasGUID, Action<CanvasDto, Exception> completed);



        void LoadCanvasForUserList(int UserId, Action<DatatableBag, Exception> completed);

        void ShareCanvas(int canvasId, List<int> sharedUserIds, Action<bool, Exception> completed);

        void ReadAllUsersInMyOrg(int orgId, Action<DatatableBag, Exception> completed);

        void DeleteCanvas(int canvasId, Action<bool, Exception> completed);

        void ResendEmail(int canvasId, List<int> sharedUserIds, Action<bool, Exception> completed);
    }
}